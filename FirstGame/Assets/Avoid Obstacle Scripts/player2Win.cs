using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player2Win : MonoBehaviour
{
    public Text WinPlayer2Text;

        void Start()
        {
            string playerName = PlayerPrefs.GetString("player2Name");

            WinPlayer2Text.text = playerName + " WIN";
        }

}
