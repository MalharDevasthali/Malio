using UnityEngine;

namespace Assets.Scripts.Player
{
    [CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "ScriptableObject/Player/NewPlayerScriptableObject")]
    public class PlayerScriptableObject : ScriptableObject
    {
        public float PlayerSpeed { private set; get; }
        public PlayerState PlayerState { private set; get; }
        public float PlayerHealth { private set; get; }
        public Vector2 playerSpawnPosition { private set; get; }
        public Animator playerAnimator { private set; get; }
    }
}