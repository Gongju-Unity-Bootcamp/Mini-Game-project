using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisonplayer : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player1") || other.CompareTag("player2"))
        {
            Destroy(other.gameObject);
        }
    }

}