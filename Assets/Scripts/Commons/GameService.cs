using Assets.Scripts.Player;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Commons
{
    public class GameService : GenericMonoSingleton<GameService>
    {
        [SerializeField] private PlayerService playerService;

        private void Start()
        {

        }
    }
}