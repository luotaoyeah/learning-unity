using UnityEngine;

namespace Scene01
{
    public class RayShooter : MonoBehaviour
    {
        public UnityEngine.Camera myCamera;

        // Start is called before the first frame update
        void Start()
        {
            myCamera = GetComponent<UnityEngine.Camera>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Vector3 point = new Vector3(myCamera.pixelWidth / 2, myCamera.pixelHeight / 2, 0);
                Ray ray = myCamera.ScreenPointToRay(point);
                if (Physics.Raycast(ray, out var hit))
                {
                    Debug.Log(hit.point);
                }
            }
        }
    }
}
