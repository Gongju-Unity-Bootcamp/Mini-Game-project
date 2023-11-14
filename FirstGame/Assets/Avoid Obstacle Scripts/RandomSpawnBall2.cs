using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnBall12 : MonoBehaviour
{
    public GameObject Ball;
    public float minX = 8.6f;
    public float maxX = 0.3f;
    public float minY = -4.7f;
    public float maxY = 4.7f;
    public float spawntime = 2f;
    public float minSpawntime;
    public float Decreasespawntime = 0.1f;
    public float initialtime = 2f;


    void Start()
    {

        Invoke("SpawnBallRandomPosition", initialtime);

    }
    void SpawnBallRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector2 spawnPosition = new Vector2(randomX, randomY);
        Instantiate(Ball, spawnPosition, Quaternion.identity);
        spawntime = Mathf.Max(minSpawntime, spawntime - Decreasespawntime);
        Invoke("SpawnBallRandomPosition", spawntime);
    }

}
