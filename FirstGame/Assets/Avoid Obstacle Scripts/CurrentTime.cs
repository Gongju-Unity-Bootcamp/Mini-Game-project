using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    private float currenttime;
    Text currentTimeText;
    // Start is called before the first frame update
    void Start()
    {
        currentTimeText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        currenttime = Time.time;
        currentTimeText.text = Time.time.ToString("F2");
    }
}
