using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    private float startTime;
    Text currentTimeText;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        currentTimeText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        float NewTime = Time.time - startTime;
        currentTimeText.text = NewTime.ToString("F2");
    }
}
