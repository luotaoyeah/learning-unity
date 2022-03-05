using UnityEngine;

namespace Scene02
{
    [RequireComponent(typeof(CharacterController))]
    [AddComponentMenu("Luotao/FPSInput")]
    public class FPSInput : MonoBehaviour
    {
        public float speed = 6f;
        public float gravity = -9.8f;
        public CharacterController characterController;

        // Start is called before the first frame update
        void Start()
        {
            characterController = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            var movement = new Vector3(Input.GetAxis("Horizontal") * speed, 0, Input.GetAxis("Vertical") * speed);
            movement = Vector3.ClampMagnitude(movement, speed);

            movement.y = gravity;
            movement *= Time.deltaTime;
            movement = transform.TransformDirection(movement);

            characterController.Move(movement);
        }
    }
}
