using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Player
{
    public class PlayerController
    {
        public PlayerView playerView { get; private set; }
        public PlayerModel playerModel { get; private set; }

        public PlayerController(PlayerModel playerModel, PlayerView playerView)
        {
            this.playerModel = playerModel;
            this.playerView = GameObject.Instantiate<PlayerView>(playerView);
        }


    }
}