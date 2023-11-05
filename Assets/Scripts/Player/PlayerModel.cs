using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerModel
    {
        public PlayerScriptableObject PlayerScriptableObject { get; private set; }

        private PlayerController playerController;
        public PlayerModel(PlayerScriptableObject playerScriptableObject)
        {
            PlayerScriptableObject = playerScriptableObject;
        }

        public void SetPlayerController(PlayerController playerController)
        {
            this.playerController = playerController;
        }

    }
}