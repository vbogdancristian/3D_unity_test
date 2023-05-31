using UnityEngine;

public class Collision : MonoBehaviour
{
    public PlayerMovement movement;
    private void OnCollisionEnter(UnityEngine.Collision collision)
    {
        if(collision.collider.tag=="Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
