using UnityEngine;

namespace Scene01
{
    public class MouseLook : MonoBehaviour
    {
        public enum RotationAxes
        {
            MouseXAndY = 0,
            MouseX = 1,
            MouseY = 2
        }

        public RotationAxes axes = RotationAxes.MouseXAndY;

        public float horizontalSensitivity = 2f;

        public float verticalSensitivity = 2f;
        public float verticalRotation = 0;
        private float maximumVerticalRotation = 45;
        private float minimumVerticalRotation = -45;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            switch (axes)
            {
                case RotationAxes.MouseX:
                {
                    var y = Input.GetAxis("Mouse X") * horizontalSensitivity;
                    transform.Rotate(0, y, 0);
                    break;
                }

                case RotationAxes.MouseY:
                {
                    verticalRotation -= Input.GetAxis("Mouse Y") * verticalSensitivity;
                    verticalRotation = Mathf.Clamp(verticalRotation, minimumVerticalRotation, maximumVerticalRotation);

                    transform.localEulerAngles = new Vector3(verticalRotation, transform.localEulerAngles.y, 0);
                    break;
                }

                case RotationAxes.MouseXAndY:
                {
                    verticalRotation -= Input.GetAxis("Mouse Y") * verticalSensitivity;
                    verticalRotation = Mathf.Clamp(verticalRotation, minimumVerticalRotation, maximumVerticalRotation);

                    transform.localEulerAngles = new Vector3(
                        verticalRotation,
                        transform.localEulerAngles.y + Input.GetAxis("Mouse X") * horizontalSensitivity,
                        0
                    );

                    break;
                }
            }
        }
    }
}
