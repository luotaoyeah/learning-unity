using UnityEngine;

namespace Scene01
{
    public class Player : MonoBehaviour
    {
        public float Speed = 0.1f;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            transform.Rotate(0, Speed, 0);
        }
    }
}
