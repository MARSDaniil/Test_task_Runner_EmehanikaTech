using UnityEngine;
namespace Config.Characters {
    [CreateAssetMenu(fileName = "ÑharacterConfig", menuName = "Configs/Characters/ÑharacterConfig")]
    public class CharactersConfig :ScriptableObject {
        public float speed;
        public bool isDead;
    }
}