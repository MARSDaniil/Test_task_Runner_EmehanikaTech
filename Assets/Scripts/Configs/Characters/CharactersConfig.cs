using UnityEngine;
namespace Config.Characters {
    [CreateAssetMenu(fileName = "�haracterConfig", menuName = "Configs/Characters/�haracterConfig")]
    public class CharactersConfig :ScriptableObject {
        public float speed;
        public bool isDead;
    }
}