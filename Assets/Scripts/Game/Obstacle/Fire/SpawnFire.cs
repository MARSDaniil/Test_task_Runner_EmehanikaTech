using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Spawn {
    public class SpawnFire :MonoBehaviour {
       [SerializeField] GameObject FireObject;
        [SerializeField] List<Transform> startPosition;
        [SerializeField] List<GameObject> fireList;
        [SerializeField] float timeBetweenFire = 10f;
        private bool canSpawn = true;
        private void SpawnBarrier() {
            bool freeObstacle = false;
            Transform transform = startPosition[GenerateRandomNumOfList(startPosition.Count)];
            for (int i = 0; i < fireList.Count; i++) {
                if (!fireList[i].activeInHierarchy) {
                    fireList[i].transform.position = transform.position;
                    fireList[i].SetActive(true);
                    freeObstacle = true;
                    break;
                }
            }
            if (!freeObstacle) {
                fireList.Add(Instantiate(FireObject, transform.position, Quaternion.identity, transform.parent));
            }
        }

        private void Update() {
            if (canSpawn) StartCoroutine(SpawnCoroutine());
        }

        IEnumerator SpawnCoroutine() {
            canSpawn = false;
            SpawnBarrier();
            yield return new WaitForSeconds(timeBetweenFire);
            canSpawn = true;
        }
        private int GenerateRandomNumOfList(int lenghtOfList) => (Random.Range(0, lenghtOfList));

        public void ClearList() {
            foreach(GameObject o in fireList) Destroy(o);
            fireList.Clear();
        }
    }
}