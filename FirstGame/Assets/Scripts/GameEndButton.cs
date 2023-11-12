using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEndButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // 버튼 클릭 이벤트에 리스너 추가
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnExitButtonClick);
        }
    }
    void OnExitButtonClick()
    {
        // 게임 종료
        Application.Quit();


    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }
}
