using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Components;
using Config.Characters;
namespace Game.Obstacle {
    public class FireMovement :Movement {
        public float extremeCoordinatsX = -20f;
        [SerializeField] ObstacleConfig obstacleConfig;
        private void Awake() {
            Init();
        }
        private void Init() {
            SetDirection(new Vector3(-1, 0, 0));
            Speed = obstacleConfig.speed;
        }

        private void Update() {
            if (gameObject.transform.position.x <= extremeCoordinatsX) {
                gameObject.SetActive(false);
            }
        }
    }
}