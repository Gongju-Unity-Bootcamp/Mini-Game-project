using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputPlayerName : MonoBehaviour
{
    public InputField player1;
    public InputField player2;

    void LockInput(InputField player1, InputField player2)
    {
        if (player1.text.Length > 0 && player2.text.Length > 0)
        {
            Debug.Log("입력 완료");
        }
        else
        {
            Debug.Log("플레이어 이름을 입력하세요.");
        }
    }
    void Start()
    {
        player1.onSubmit.AddListener(delegate { LockInput(player1, player2); }) ;
    }
}
