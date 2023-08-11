using UnityEngine;
namespace Config.Characters {
    [CreateAssetMenu(fileName = "ObstacleConfig", menuName = "Configs/Obstacle/ObstacleConfig")]
    public class ObstacleConfig :ScriptableObject {
        public float speed;
    }
}