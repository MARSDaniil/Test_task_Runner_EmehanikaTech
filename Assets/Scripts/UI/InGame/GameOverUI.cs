using UnityEngine;
using UI.Common;
using TMPro;
namespace UI.InGame {
    public class GameOverUI :MenuWindow {
        [SerializeField]PauseMenu pauseMenu;
        [SerializeField] TMP_Text currScoreText;
        [SerializeField] TMP_Text recordScoreText;
        public override void Init(bool isOpen = false) {
            base.Init(isOpen);
            pauseMenu.Init(true);
        }
            
        public void SetCurrScore(int value) => currScoreText.text = "score = " + value.ToString();
        public void SetRecordScore() => recordScoreText.text = "record score = " + PlayerPrefs.GetInt("MaxScore").ToString();

    }
}