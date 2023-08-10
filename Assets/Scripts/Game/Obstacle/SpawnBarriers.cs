using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Game.Obstacle;
namespace Game.Spawn {
    public class SpawnBarriers :MonoBehaviour {
        [SerializeField] List<GameObject> PrefabsOfBarriers;
        [SerializeField] Transform startPosition;
        [SerializeField] List<GameObject> barriersList;
        [SerializeField] float timeBetweenBarriers = 10f;
        private bool canSpawn = true;
        private void SpawnBarrier() {
            bool freeObstacle = false;

            for (int i = 0; i < barriersList.Count; i++) {
                if (!barriersList[i].activeInHierarchy) {
                    barriersList[i].transform.position = startPosition.position;
                    barriersList[i].SetActive(true);
                    freeObstacle = true;
                    break;
                }
            }
            if (!freeObstacle) {
                barriersList.Add(Instantiate(PrefabsOfBarriers[GenerateRandomNumOfList(PrefabsOfBarriers.Count)],
                    startPosition.transform.position, Quaternion.identity, transform.parent));
            }
        }

        private void Update() {
            if (canSpawn) StartCoroutine(SpawnCoroutine());
        }

        IEnumerator SpawnCoroutine() {
            canSpawn = false;
            SpawnBarrier();
            yield return new WaitForSeconds(timeBetweenBarriers);
            canSpawn = true;
        }
        private int GenerateRandomNumOfList(int lenghtOfList) => (Random.Range(0, lenghtOfList));

        public void ClearList() {
            barriersList.Clear();
        }

        /*
        public void SetSpeed(float value) {
            foreach (GameObject o in barriersList) {
                ObstacleMovement obstacleMovement = o.GetComponent<ObstacleMovement>();
                obstacleMovement.SetSpeed(value);
            }
        }
        */
    }
}