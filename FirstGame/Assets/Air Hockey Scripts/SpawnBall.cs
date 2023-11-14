using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class SpawnBall : MonoBehaviour
{
    private Transform TF;
    public Transform spawnPoint; // 생성할 위치
    public GameObject Ball;
    // Start is called before the first frame update
    void Update()
    {
        CreateNewBall();
    }
    void CreateNewBall()
    {
        if (GameObject.FindGameObjectsWithTag("ball").Length == 0)
        {
            GameObject newBall = Instantiate(Ball, spawnPoint.position, Quaternion.identity);
        }
    }


    // Update is called once per frame

}
