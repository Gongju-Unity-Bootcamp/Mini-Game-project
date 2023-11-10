using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetScore : MonoBehaviour
{
    public float MindestroyXPosition = -9;
    public float MaxdestroyXPosition = 9;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentXPosition = transform.position.x;

        if (currentXPosition < MindestroyXPosition)
        {
            Destroy(gameObject);
        }
        if(currentXPosition > MaxdestroyXPosition)
        {
            Destroy(gameObject);
        }
    }
}
