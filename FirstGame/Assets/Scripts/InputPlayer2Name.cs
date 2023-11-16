using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPlayer2Name : MonoBehaviour
{
    public InputField player2;
    void LockInput(InputField player2)
    {
        PlayerPrefs.SetString("player2Name", player2.text);
    }
    private void Start()
    {
        player2.onSubmit.AddListener(delegate { LockInput(player2); });
    }
}