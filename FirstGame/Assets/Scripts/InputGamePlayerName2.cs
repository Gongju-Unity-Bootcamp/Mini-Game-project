using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputGamePlayerName2 : MonoBehaviour
{
    public Text player2NameText;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("player2Name");

        player2NameText.text = playerName;
    }
}
