using UnityEngine;

namespace Scene00
{
    public class HelloWorld : MonoBehaviour
    {
        // Start is called before the first frame update
        private void Start()
        {
            Debug.Log("HELLO WORLD");
            Debug.LogWarning("HELLO WORLD");
            Debug.LogError("HELLO WORLD");
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}
