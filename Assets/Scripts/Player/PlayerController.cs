using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerController
    {

        private PlayerState currentPlayerState;

        public PlayerView playerView { get; private set; }
        public PlayerModel playerModel { get; private set; }

        public PlayerController(PlayerModel playerModel, PlayerView playerView)
        {
            this.playerModel = playerModel;
            SpawnPlayer(playerView);
        }

        public void PlayerMovement(float horizMovement, Rigidbody2D rb2D)
        {
            if (horizMovement != 0)
            {
                SetState(PlayerState.Walking);
                float speed = playerModel.PlayerScriptableObject.PlayerSpeed;
                rb2D.velocity = new Vector2((horizMovement * speed), rb2D.velocity.y);
                playerModel.PlayerScriptableObject.playerAnimator.SetBool("isMoving", true);
            }
            else
            {
                if (currentPlayerState == PlayerState.Walking)
                {
                    SetState(PlayerState.Idle);
                    playerModel.PlayerScriptableObject.playerAnimator.SetBool("isMoving", true);
                }
            }
        }

        private void SpawnPlayer(PlayerView playerView)
        {
            this.playerView = GameObject.Instantiate<PlayerView>(playerView);
            this.playerView.SetController(this);
            SetState(PlayerState.Idle);
            this.playerView.transform.position = this.playerModel.PlayerScriptableObject.playerSpawnPosition;
        }

        public void SetState(PlayerState state)
        {
            currentPlayerState = state;
        }
    }
}