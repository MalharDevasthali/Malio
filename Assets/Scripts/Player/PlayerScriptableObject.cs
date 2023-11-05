using UnityEngine;

namespace Assets.Scripts.Player
{
    [CreateAssetMenu(fileName = "PlayerScriptableObject", menuName = "ScriptableObject/Player/NewPlayerScriptableObject")]
    public class PlayerScriptableObject : ScriptableObject
    {
        public float PlayerSpeed;
        public float PlayerHealth;
    }
}