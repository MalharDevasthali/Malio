using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerService : MonoBehaviour
    {
        [SerializeField] private PlayerScriptableObject playerScriptableObject;
        [SerializeField] private PlayerView playerView;

        private PlayerController playerController;
        private void Start()
        {
            CreatePlayer();
        }

        private void CreatePlayer()
        {
            PlayerModel playerModel = new PlayerModel(playerScriptableObject);
            playerController = new PlayerController(playerModel, playerView);

        }

    }
}