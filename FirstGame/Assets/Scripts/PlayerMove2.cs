using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerMove2 : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float moveRange = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
           Vector2 move =  Vector2.up * moveSpeed * Time.deltaTime;
            transform.Translate(move);
        }
        if(Input.GetKey(KeyCode.DownArrow))
        {
            Vector2 move = Vector2.down * moveSpeed * Time.deltaTime;
            transform.Translate(move);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector2 move = Vector2.right * moveSpeed * Time.deltaTime;
            transform.Translate(move);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector2 move = Vector2.left * moveSpeed * Time.deltaTime;
            transform.Translate(move);
        }

        float newY = Mathf.Clamp(transform.position.y, -moveRange, moveRange);
        transform.position = new Vector2(transform.position.x, newY);
    }
}
