using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManger : MonoBehaviour
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
        if (menuSetActive == false )
        {
            Time.timeScale = 1f;
        }

    }
    
       
    


}
