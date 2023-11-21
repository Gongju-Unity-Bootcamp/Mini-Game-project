using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudio : MonoBehaviour
{
    public AudioClip effectSound;
    public AudioClip GoalSound;


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player") || collision.gameObject.CompareTag("wall"))
        {
            AudioSource.PlayClipAtPoint(effectSound, transform.position);
        }
        if (collision.gameObject.CompareTag("player1 wall") || collision.gameObject.CompareTag("player2 wall"))
        {
            AudioSource.PlayClipAtPoint(GoalSound, transform.position);
        }
    }
}
