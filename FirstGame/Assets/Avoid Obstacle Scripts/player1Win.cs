using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class player1Win : MonoBehaviour
{
    public Text WinPlayer1Text;
    // Start is called before the first frame update

        void Start()
        {
            string playerName = PlayerPrefs.GetString("player1Name");

            WinPlayer1Text.text = playerName + " WIN";
        }
    


}