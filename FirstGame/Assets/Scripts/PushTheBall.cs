using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushTheBall : MonoBehaviour
{
    public float pushForce = 10.0f; // 공이 밀릴때 적용되는 힘의 세기
    private Rigidbody2D RB;
    public float rotationSpeed = 500.0f;
    public float tiltAngle = 30f;
    public float accelerationRate = 0.1f;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;
        // Z 축 주위로 회전합니다. (2D 공간에서는 주로 Z 축으로 회전)
        transform.Rotate(Vector3.forward, rotationAmount);

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("player"))
        {
                Vector2 direction = collision.contacts[0].normal;
                RB.AddForce(direction * pushForce, ForceMode2D.Impulse);
        }
        if (collision.gameObject.CompareTag("wall"))
        {
                Vector2 direction = collision.contacts[0].normal;
                RB.AddForce(direction * pushForce, ForceMode2D.Impulse);  
        }

        

    }
}