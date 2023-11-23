using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player1 wall"))
        {
            Destroy(gameObject);
            Score2.player2Score++;
        }
        if (collision.gameObject.CompareTag("player2 wall"))
        {
            Destroy(gameObject);
            Score.player1Score++;
        }

    }
}
