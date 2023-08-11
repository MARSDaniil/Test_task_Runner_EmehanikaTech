using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Spawn;
using Game.Obstacle;
namespace Game {
    public class LevelController :MonoBehaviour {
        [Header("Obstacle")]
        [SerializeField] List<GameObject> backgroundList;
        [SerializeField] List<GameObject> roofList;
        [SerializeField] List<GameObject> groundList;
        [Header("Barriers")]
        [SerializeField] SpawnBarriers spawnBarriers;
        [SerializeField] SpawnFire spawnFire;
        private InGameManager _inGameManager;

        public void Init(InGameManager value) {
            _inGameManager = value;
            SetStartPosition();
        }

        public void SetStartPosition() {
            SetPositionToList(backgroundList);
            SetPositionToList(roofList);
            SetPositionToList(groundList);
            
            spawnFire.ClearList();
            spawnBarriers.ClearList();
        }

        private void SetPositionToList(List<GameObject> list) {
            for (int i = 0; i < list.Count; i++) {
                list[i].transform.position = new Vector3(
                     (i + 1) * 10 - 15,
                     list[i].transform.position.y,
                     list[i].transform.position.z
                    );
            }
        }
        /*
        public void GetSpeed(float value) {
            if (GeneralSpeed != value) {
                GeneralSpeed = value;
                SetSpeed();
                spawnBarriers.SetSpeed(value);
            }
        }

        private void SetSpeed() {
            /*
            foreach(GameObject o in obstacleList) {
                ObstacleMovement obstacleMovement = o.GetComponent<ObstacleMovement>();
                obstacleMovement.SetSpeed(GeneralSpeed);
            }
            for(int i = 0; i < obstacleList.Count; i++) {
                ObstacleMovement obstacleMovement = obstacleList[i].GetComponent<ObstacleMovement>();
                obstacleMovement.SetSpeed(GeneralSpeed);
            }
        }
        */
    }
}