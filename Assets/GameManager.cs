using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    [HideInInspector]
    public bool gameHasEnded = false;
    public float restartDelay= 1.0f;
    public void EndGame(){
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

