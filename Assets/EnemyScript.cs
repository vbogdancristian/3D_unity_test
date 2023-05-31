using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    PlayerMovement playerMovement;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        rb= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(playerMovement.rb.position.z>= rb.position.z + 50)
        {
            Destroy(gameObject);
        }
    }
}
