using UnityEngine;

public class Slow : MonoBehaviour
{
    PlayerMovement playerMovement;
    Rigidbody rb;
    private void Start()
    {
        playerMovement = FindObjectOfType<PlayerMovement>();
        rb = GetComponent<Rigidbody>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playerMovement.forwardSpeed /= 1.25f;
            Destroy(gameObject);
        }
    }
    void FixedUpdate()
    {
        if (playerMovement.rb.transform.position.z >= rb.transform.position.z + 50)
        {
            Destroy(gameObject);
        }
    }

}
