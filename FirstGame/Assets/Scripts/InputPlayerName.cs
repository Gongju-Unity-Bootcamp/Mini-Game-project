using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPlayerName : MonoBehaviour
{
    public InputField player1;
    void LockInput(InputField player1)
    {
        PlayerPrefs.SetString("player1Name", player1.text);
    }
    private void Start()
    {
        player1.onSubmit.AddListener(delegate { LockInput(player1); }) ;
    }
}
