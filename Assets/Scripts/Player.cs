using System;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody myRigidBody;

    public TextMeshProUGUI Text;

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
        Text.text = DateTime.Now.ToString();

        myRigidBody.AddForce(new Vector3(h, 0, v) * 2);
    }
}
