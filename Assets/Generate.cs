using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Generate : MonoBehaviour
{
    int random;
    public List <GameObject> list = new List <GameObject>();
    int POW;
    Vector3 powerUpPosition;
    int[] arr = { -9, -5, 0, 5, 9 };
    public GameObject enemy;
    public int spawn_distance;
    public Rigidbody playerRb;
    Vector3 enemyPosition;
    GameManager gameManager;
    public float spawnInterval;
    float last_spawnTime=0.0f;
    int xValue;
    void Start()
    {
        gameManager = GetComponent<GameManager>();
    }
    void FixedUpdate()
    {
        if (Time.time-last_spawnTime >= spawnInterval && gameManager.gameHasEnded==false)
        {
            random = Random.Range(0, 10);
            if (random > 0)
            {
                last_spawnTime = Time.time;
                xValue = arr[Random.Range(0, arr.Length)];
                enemyPosition = new Vector3(xValue, 1, playerRb.position.z + spawn_distance);
                Instantiate(enemy, enemyPosition, Quaternion.identity);
            }
            else
            {
                last_spawnTime = Time.time;
                xValue = arr[Random.Range(0, arr.Length)];
                powerUpPosition = new Vector3(xValue, 1, playerRb.position.z + spawn_distance);
                POW = Random.Range(1, list.Count);
                Instantiate(list[POW-1], powerUpPosition, Quaternion.identity);
            }
        }
       
    }
}
