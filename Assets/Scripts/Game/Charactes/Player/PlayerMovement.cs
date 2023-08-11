using UnityEngine;
using Game.Components;
namespace Game.Characters.Player {
    public class PlayerMovement :Movement {
        Animator animator;
        Rigidbody rigidbody;

        private bool isOnGround = true;
        [SerializeField] float jumpForce = 2f;
        [SerializeField] Transform groundCheker;
        private float distancseToGround = 0.3f;
        [SerializeField] LayerMask groundLayer;
        
        public void Start() {
            animator = GetComponent<Animator>();
            Direction = new Vector3(0, 0, 1f);
            rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = new Vector3(0, 0, 0);
        }
        public override void FixedUpdate() {
            rigidbody.velocity = new Vector3(0, rigidbody.velocity.y, 0);
            if(Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space)) {
                Jump();
            }
            if (isOnGround) {
                animator.SetFloat("speed", Vector3.ClampMagnitude(Direction, 1).magnitude);
            }
            if (Physics.Raycast(groundCheker.transform.position, Vector3.down, distancseToGround, groundLayer)) {
                animator.SetBool("isInAir", false);
            }
            else {
                animator.SetBool("isInAir", true);
            }

        }
      
        public void SetSpeed(float value) => Speed = value;

        private void Jump() {
            if(Physics.Raycast(groundCheker.transform.position, Vector3.down, distancseToGround, groundLayer)) {
                rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                animator.SetTrigger("jump");
            }
        }
    }
}