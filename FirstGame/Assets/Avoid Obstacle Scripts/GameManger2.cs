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
            Time.timeScale = 0f;  // ����UI�� ų�� ���� �Ͻ�����
        }
        GameObject[] player1 = GameObject.FindGameObjectsWithTag("player1");
        GameObject[] player2 = GameObject.FindGameObjectsWithTag("player2");
        if (menuSetActive == false && player1.Length == 1 && player2.Length == 1) //WinUi, WinUi2 ��ũ��Ʈ���� Time.timeScale���� �浹�ϴ°���
   //���� ���� player1�� player2 ������Ʈ�� �����Ҵ븸 Time.timeScale = 1f�� ����ǵ��� �Ͽ���.
        {
            Time.timeScale = 1f;
        }

    }





}
