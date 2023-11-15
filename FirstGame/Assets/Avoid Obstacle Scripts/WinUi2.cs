using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinUi2 : MonoBehaviour
{
    public GameObject WinUI2;
    private bool winuiSetActive = false;

    void Start()
    {
        WinUI2.SetActive(winuiSetActive);
    }

    private void Update()
    {
        VisableWinUi();
        if(winuiSetActive)
        {
            Time.timeScale = 0f;
        }
    }
    void VisableWinUi()
    {
        GameObject[] player1 = GameObject.FindGameObjectsWithTag("player1");
        if (player1.Length == 0)
        {
            winuiSetActive = true;
            WinUI2.SetActive(winuiSetActive);
        }
    }
}
