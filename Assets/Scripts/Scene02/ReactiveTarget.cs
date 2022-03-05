using System.Collections;
using UnityEngine;

namespace Scene02
{
    public class ReactiveTarget : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
        }

        /**
         * 被击中了.
         */
        public void ReactToHit()
        {
            WanderingAI behavior = GetComponent<WanderingAI>();
            if (behavior != null)
            {
                behavior.SetAlive(false);
            }

            StartCoroutine(Die());
        }

        private IEnumerator Die()
        {
            GameObject _gameObject = gameObject;

            _gameObject.transform.Rotate(-75, 0, 0);

            yield return new WaitForSeconds(1.5f);

            Destroy(_gameObject);
        }
    }
}
