using UnityEngine;

namespace Scene01
{
    public class WanderingAI : MonoBehaviour
    {
        public float speed = 3.0f;
        public float obstacleDistance = 5.0f;
        private bool isAlive;

        // Start is called before the first frame update
        void Start()
        {
            isAlive = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (!isAlive)
            {
                return;
            }

            transform.Translate(0, 0, speed * Time.deltaTime);

            Ray ray = new Ray(transform.position, transform.forward);
            if (Physics.SphereCast(ray, 0.75f, out RaycastHit raycastHit))
            {
                if (raycastHit.distance < obstacleDistance)
                {
                    int angle = Random.Range(-110, 110);
                    transform.Rotate(0, angle, 0);
                }
            }
        }

        public void SetAlive(bool alive)
        {
            isAlive = alive;
        }
    }
}