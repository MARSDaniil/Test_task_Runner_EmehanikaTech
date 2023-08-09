using UnityEngine;
namespace Game.Characters.Player {
    public class Player :Character {

        PlayerMovement _playerMovement;

        private void Awake() {
            Init();
        }
        public override void Init() {
            base.Init();
            _playerMovement = GetComponent<PlayerMovement>();
            _playerMovement.SetSpeed(Speed);
        }
        public void SetVectorByJoystick(Vector2 value) {
            _playerMovement.SetDirectionVector(value);
        }
        private void Start() {
        }

    }
}