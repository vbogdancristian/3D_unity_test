using System.Diagnostics;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardSpeed;
    public float sideSpeed;
    public float acc;
    // poate punem acc.
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }
    // Update is called once per frame
    void FixedUpdate()///important 
    {
        forwardSpeed += acc;
        rb.AddForce(0, 0, forwardSpeed* Time.deltaTime);
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sideSpeed * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(sideSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y<-1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
