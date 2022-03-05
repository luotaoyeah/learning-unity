using UnityEngine;

namespace Scene02
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

        public float sensitivityHor = 9f;
        public float sensitivityVert = 9f;

        private float minimumVert = -45f;
        private float maximumVert = 45f;

        public float verticalRot = 0;

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
                    var y = Input.GetAxis("Mouse X") * sensitivityHor;

                    transform.Rotate(0, y, 0);

                    // 下面这种方式效果一样的
                    // transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + y, 0);
                    break;
                }

                case RotationAxes.MouseY:
                {
                    verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
                    verticalRot = Mathf.Clamp(verticalRot, minimumVert, maximumVert);

                    transform.localEulerAngles = new Vector3(verticalRot, transform.localEulerAngles.y, 0);
                    break;
                }

                case RotationAxes.MouseXAndY:
                {
                    var y = Input.GetAxis("Mouse X") * sensitivityHor;

                    verticalRot -= Input.GetAxis("Mouse Y") * sensitivityVert;
                    verticalRot = Mathf.Clamp(verticalRot, minimumVert, maximumVert);

                    transform.localEulerAngles = new Vector3(verticalRot, transform.localEulerAngles.y + y, 0);
                    break;
                }
            }
        }
    }
}
