using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            GameExit();
    }

    public void GameExit()
    {
        #if (UNITY_EDITOR)
        
            UnityEditor.EditorApplication.isPlaying = false;

        #else
        
            Application.Quit();
        #endif


    }
}
