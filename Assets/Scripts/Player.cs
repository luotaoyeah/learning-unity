using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START...");
    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody.AddForce(Vector3.right);
    }
}
