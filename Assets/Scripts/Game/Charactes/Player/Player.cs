using UnityEngine;
namespace Game.Characters.Player {
    public class Player :Character {

        PlayerMovement _playerMovement;
        public InGameManager _inGameManager;
        private void Awake() {
            Init();
        }
        public override void Init() {
            base.Init();
            _playerMovement = GetComponent<PlayerMovement>();
            _playerMovement.SetSpeed(Speed);
            if (!_inGameManager) {
                UnityEngine.Debug.LogError($"{this} has not found {nameof(_inGameManager)}");
            }
        }

        public void OnCollisionEnter(Collision collision) {
            if(collision.gameObject.tag == "Water") _inGameManager.MinusFire();
            if(collision.gameObject.tag == "Fire") _inGameManager.PlusFire();
        }

    }
}