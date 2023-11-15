using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject MenuSet;
    public bool menuSetActive = false;
    private void Start()
    {
        MenuSet.SetActive(menuSetActive);
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.F10))
        {

            menuSetActive = !menuSetActive;
            MenuSet.SetActive(menuSetActive);
            Time.timeScale = 0f;  // 설정UI를 킬때 게임 일시정지
        }
        GameObject[] player1 = GameObject.FindGameObjectsWithTag("player1");
        GameObject[] player2 = GameObject.FindGameObjectsWithTag("player2");
        if (menuSetActive == false && player1.Length == 1 && player2.Length == 1) //WinUi, WinUi2 스크립트에서 Time.timeScale값이 충돌하는것을
   //막기 위해 player1과 player2 오브젝트가 존재할대만 Time.timeScale = 1f이 적용되도록 하였다.
        {
            Time.timeScale = 1f;
        }

    }





}
