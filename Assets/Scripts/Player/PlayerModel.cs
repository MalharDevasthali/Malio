using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerModel
    {
        public float PlayerSpeed { get; private set; }
        public float PlayerHealth { get; private set; }

        private PlayerController playerController;
        public PlayerModel(PlayerScriptableObject playerScriptableObject)
        {
            PlayerSpeed = playerScriptableObject.PlayerSpeed;
            PlayerHealth = playerScriptableObject.PlayerHealth;
        }

        public void SetPlayerController(PlayerController playerController)
        {
            this.playerController = playerController;
        }

    }
}