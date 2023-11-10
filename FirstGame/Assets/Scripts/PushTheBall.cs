using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushTheBall : MonoBehaviour
{
    public float pushForce = 10.0f; // ���� �и��� ����Ǵ� ���� ����

    private Rigidbody2D RB; 

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            Vector2 direction = collision.contacts[0].normal; 

            RB.AddForce(direction * pushForce, ForceMode2D.Impulse);
        }
    }
}