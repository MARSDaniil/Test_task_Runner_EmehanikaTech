using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UI.Common;
using UI.InGame;
namespace UI.MenuUI {
    public class MenuCanvas :MenuWindow {
        [SerializeField] StartGame startGame;
        [SerializeField] InfoPanel infoPanel;
        [HideInInspector] public InGameUIManager inGameUIManager;
        public override void Init(bool isOpen = false) {
            base.Init(isOpen);
            inGameUIManager = GetComponentInParent<InGameUIManager>();
            startGame.Init(true);
            infoPanel.Init(true);
        }
    }
}