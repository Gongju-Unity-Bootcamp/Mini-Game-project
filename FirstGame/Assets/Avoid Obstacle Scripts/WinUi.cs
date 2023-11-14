using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinUi : MonoBehaviour
{
    public GameObject WinUI;
    private bool winuiSetActive = false;

    void Start()
    {
        WinUI.SetActive(winuiSetActive);
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
        GameObject[] player2 = GameObject.FindGameObjectsWithTag("player2");
        if(player2.Length == 0)
        {
            winuiSetActive = true;
            WinUI.SetActive(winuiSetActive);
        }
    }
}
