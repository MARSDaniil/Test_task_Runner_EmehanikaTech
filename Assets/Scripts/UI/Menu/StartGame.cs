using System.Collections;
using UnityEngine;
using UI.Common;
using TMPro;
using Game;
namespace UI.MenuUI{
	public class StartGame :MenuWindow {
		//public TMP_Text timingText;
	
		InGameManager _inGameManager;
		public void Init() {
			/*_inGameManager = FindObjectOfType<InGameManager>();
			if (!_inGameManager) {
				UnityEngine.Debug.Log($"{this} has not found {nameof(_inGameManager)}");
			}
			StartCoroutine(TimerCoroutine());
			*/
		}
		/*
		IEnumerator TimerCoroutine() {
			while (timeOfWaitSecond >= 0) {
				timingText.text = timeOfWaitSecond.ToString();
				yield return new WaitForSeconds(timeInterval);
				timeOfWaitSecond--;
			}
			if (timeOfWaitSecond < 0) {
				_inGameManager.isStartGameClose = true;
				this.Close();
			}
		}
		*/
	}
}