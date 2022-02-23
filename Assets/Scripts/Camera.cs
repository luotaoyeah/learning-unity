using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform PalyerTransform;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - PalyerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = PalyerTransform.position + offset;
    }
}
