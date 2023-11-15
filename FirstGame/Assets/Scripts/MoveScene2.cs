using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveScene2 : MonoBehaviour
{
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(LoadMainScene);
    }

    void Update()
    {
        
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene("Avoid Obstacle");
    }
}
