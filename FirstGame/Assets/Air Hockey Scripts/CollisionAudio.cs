using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAudio : MonoBehaviour
{
    public AudioSource audioSource;
    void Start()
    {
        audioSource = this.gameObject.GetComponent<AudioSource>();
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
                this.audioSource.Play();
        }
    }
}
