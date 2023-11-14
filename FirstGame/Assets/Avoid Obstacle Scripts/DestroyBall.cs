using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBall : MonoBehaviour
{
    void Start()
    {
        
    }
    void Update()
    {
        if (transform.position.x < -9 || transform.position.x > 9 ||
            transform.position.y>5 || transform.position.y<-5)
        {
            Destroy(gameObject);
        }
    }
}
