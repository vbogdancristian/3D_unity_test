using TMPro;
using UnityEngine;
public class Score : MonoBehaviour
{
    public Transform score;
    TMP_Text scoreText;
    private void Start()
    {
        scoreText = GetComponent<TMP_Text>();

    }
    void Update()
    {
        //Debug.Log(score.position.z);
        scoreText.text = score.position.z.ToString("0");
    }
}
