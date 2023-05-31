using Unity.VisualScripting;
using UnityEngine;
public class Spin : MonoBehaviour
{
    float t=0f;
    Vector3 aux;
    Vector3 startPosition, endPosition;
    public float interval=2.0f;
    public float height;
    float elapseDuration;
    void Start()
    {
        startPosition = transform.position;
        endPosition = new Vector3(startPosition.x, startPosition.y + height, startPosition.z);
    }

    void Update()
    {
        transform.Rotate(0f, 0.5f, 0f);
        transform.position = Vector3.Lerp(startPosition,endPosition,t);
        t = elapseDuration / interval;
        elapseDuration += Time.deltaTime;
        if(t>=1f)
        {
            t = 0f;
            aux = startPosition; 
            startPosition = endPosition;
            endPosition = aux;
            elapseDuration = 0f;
        }
    }
}
