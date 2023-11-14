using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnBall2 : MonoBehaviour
{
    public GameObject Ball;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float spawntime;
    public float minSpawntime;
    public float Decreasespawntime;
    public float initialtime;


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
