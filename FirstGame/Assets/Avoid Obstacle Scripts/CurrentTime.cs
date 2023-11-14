using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CurrentTime : MonoBehaviour
{
    Text currentTimeText;
    // Start is called before the first frame update
    void Start()
    {
        currentTimeText = GetComponent<Text>();
    }
    // Update is called once per frame
    void Update()
    {
        currentTimeText.text = Time.time.ToString("F2");
    }
}
