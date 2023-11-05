using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rb2D;
        private PlayerController playerController;

        private void Update()
        {
            playerController.PlayerMovement(Input.GetAxis("Horizontal"), rb2D);
        }

        public void SetController(PlayerController controller)
        {
            this.playerController = controller;
        }
    }
}