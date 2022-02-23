using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();

        Debug.Log("START...");
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        myRigidBody.AddForce(new Vector3(h, 0, v) * 5);
    }
}
