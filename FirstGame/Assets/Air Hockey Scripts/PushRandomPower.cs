using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushRandomPower : MonoBehaviour
{
    public float power = 5f;
    private Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        //방향을 랜덤으로 공에게 힘을 가한다
        RB = GetComponent<Rigidbody2D>();
        Vector2 randomDirection = Random.insideUnitCircle.normalized;
        float RandomPower = Random.Range(power, power);
        Vector2 force = randomDirection * RandomPower;
        RB.AddForce(force, ForceMode2D.Impulse);
    }

    // Update is called once per frame

}
