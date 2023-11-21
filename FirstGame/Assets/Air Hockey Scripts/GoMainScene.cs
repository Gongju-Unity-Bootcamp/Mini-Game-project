using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoMainScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(LoadMainScene);
    }

    public void LoadMainScene()
    {
        Score.player1Score = 0;
        Score2.player2Score = 0;
        SceneManager.LoadScene("MainScene");
    }

}
