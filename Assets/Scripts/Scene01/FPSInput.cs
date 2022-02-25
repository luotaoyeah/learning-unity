using UnityEngine;

namespace Scene01
{
    public class FPSInput : MonoBehaviour
    {
        public float speed = 0.6f;
        public CharacterController characterController;

        // Start is called before the first frame update
        void Start()
        {
            characterController = GetComponent<CharacterController>();
        }

        // Update is called once per frame
        void Update()
        {
            var deltaX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            var deltaZ = Input.GetAxis("Vertical") * speed * Time.deltaTime;

            var movement = new Vector3(deltaX, 0, deltaZ);
            movement = Vector3.ClampMagnitude(movement, speed);
            movement = transform.TransformDirection(movement);

            characterController.Move(movement);
        }
    }
}
