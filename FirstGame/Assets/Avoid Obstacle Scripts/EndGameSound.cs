using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGameSound : MonoBehaviour
{
    public AudioClip endgamesound;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player1") || collision.gameObject.CompareTag("player2"))
        {
            AudioSource.PlayClipAtPoint(endgamesound, transform.position);
        }
    }
    }
