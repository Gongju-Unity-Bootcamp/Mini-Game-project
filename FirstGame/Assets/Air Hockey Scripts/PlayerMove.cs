using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float moveRangeX = 9.75f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
           Vector2 move =  Vector2.up * moveSpeed * Time.deltaTime;
            transform.Translate(move);
        }
        if(Input.GetKey(KeyCode.S))
        {
            Vector2 move = Vector2.down * moveSpeed * Time.deltaTime;
            transform.Translate(move);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector2 move = Vector2.left * moveSpeed * Time.deltaTime;
            transform.Translate(move);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector2 move = Vector2.right * moveSpeed * Time.deltaTime;
            transform.Translate(move);
        }


        float newX = Mathf.Clamp(transform.position.x, -moveRangeX, -0.5f);
        float newY = Mathf.Clamp(transform.position.y, -5.2f, 3.4f);
        transform.position = new Vector2(newX, newY);

    }
}
