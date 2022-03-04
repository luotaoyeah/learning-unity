using System;
using UnityEngine;

namespace Scene01
{
    public class Fireball : MonoBehaviour
    {
        private float speed = 10f;

        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            transform.Translate(0, 0, speed * Time.deltaTime);
        }

        private void OnTriggerEnter(Collider other)
        {
            PlayerCharacter playerCharacter = other.GetComponent<PlayerCharacter>();
            if (playerCharacter != null)
            {
                Debug.Log("Player Hit");
            }

            Destroy(gameObject);
        }
    }
}
