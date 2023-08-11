using UnityEngine;
using UI.Common;
using TMPro;
namespace UI.InGame {
    public class GameOverUI :MenuWindow {
        [SerializeField]PauseMenu pauseMenu;
        public override void Init(bool isOpen = false) {
            base.Init(isOpen);
            pauseMenu.Init(true);
        } 
    }
}