using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform palyerTransform;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - palyerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = palyerTransform.position + offset;
    }
}
