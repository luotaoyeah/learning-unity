using System.Collections;
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

            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
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
                    StartCoroutine(SphereIndicator(hit.point));
                }
            }
        }

        private void OnGUI()
        {
            int fontSize = 32;
            float x = myCamera.pixelWidth / 2 - fontSize / 4;
            float y = myCamera.pixelHeight / 2 - fontSize / 2;

            GUI.Label(
                new Rect(x, y, fontSize, fontSize),
                "〇",
                new GUIStyle()
                {
                    fontSize = fontSize,
                }
            );
        }

        private IEnumerator SphereIndicator(Vector3 position)
        {
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = position;
            yield return new WaitForSeconds(1);
            Destroy(sphere);
        }
    }
}
