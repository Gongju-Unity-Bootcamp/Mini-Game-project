using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveOne : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float moveRangeX;
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


        float newX = Mathf.Clamp(transform.position.x, -moveRangeX, -0.3f);
        float newY = Mathf.Clamp(transform.position.y, -4.7f, 4.7f);
        transform.position = new Vector2(newX, newY);

    }
}
