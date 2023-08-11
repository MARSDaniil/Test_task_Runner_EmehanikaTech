using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI.Common;
using TMPro;
namespace UI.InGame {
    public class Score :MenuWindow {
        [SerializeField] TMP_Text scoreText;
        private bool canChange = true;
        private int score = 0;
        static private int startFireScore = 3;
        static private int maxFire = 7;
        public int currentFireScore = 3;
        public List<GameObject> fireList;
        [SerializeField] InGameCanvas inGameCanvas;
        public override void Init(bool isOpen = false) {
            base.Init(isOpen);
            scoreText.text = score.ToString();
            StartFire();
        }

        private void Update() {
            if (canChange) StartCoroutine(TimerCoroutine());
        }
        IEnumerator TimerCoroutine() {
            canChange = false;
            yield return new WaitForSeconds(1f);
            score++;
            scoreText.text = score.ToString();
            canChange = true;
        }

        public void StartFire() {
            currentFireScore = startFireScore;
            foreach(GameObject o in fireList) {
                o.SetActive(false);
            }
            for(int i = 0; i < startFireScore; i++) {
                fireList[i].SetActive(true);
            }
            score = 0;
            scoreText.text = score.ToString();
            canChange = true;
        }

        public void MinusFire() {
            currentFireScore--;
            if(currentFireScore > 0) {
                fireList[currentFireScore].SetActive(false);
            }
            else {
                fireList[currentFireScore].SetActive(false);
                inGameCanvas.GameOver();
            }
        }
        public void PlusFire() {
            currentFireScore++;
            if (currentFireScore != maxFire) {
                fireList[currentFireScore-1].SetActive(true);
            }
            else {
                currentFireScore--;
                score++;
                scoreText.text = score.ToString();
            }
        }
        public void ChangeScore(bool value) => canChange = value;

        
    }
}