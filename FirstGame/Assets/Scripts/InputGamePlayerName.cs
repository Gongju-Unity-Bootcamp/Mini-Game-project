using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputGamePlayerName : MonoBehaviour
{
    public Text playerNameText;

    void Start()
    {
        string playerName = PlayerPrefs.GetString("player1Name");

        playerNameText.text = playerName;
    }


}
