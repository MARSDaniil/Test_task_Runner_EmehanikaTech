using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Components; 
using Config.Characters; 
namespace Game.Obstacle {

    public class ObstacleMovement :Movement {
        public float extremeCoordinatsX = -20f;
        [SerializeField] ObstacleConfig obstacleConfig;
        public Vector3 direction;
        private void Awake() {
            Init();
        }
        private void Init() {
            SetDirection(direction);
            Speed = obstacleConfig.speed;
        }

        private void Update() {
            if (gameObject.transform.position.x <= extremeCoordinatsX) {
                transform.position = new Vector3(Mathf.Abs(extremeCoordinatsX), transform.position.y, transform.position.z);
            }
        }

        //public void SetSpeed(float value) => Speed = value;
    }
}
