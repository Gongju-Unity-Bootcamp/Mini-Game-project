using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushTheBall : MonoBehaviour
{
    public float pushForce = 10.0f; // ���� �и��� ����Ǵ� ���� ����
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
        // Z �� ������ ȸ���մϴ�. (2D ���������� �ַ� Z ������ ȸ��)
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