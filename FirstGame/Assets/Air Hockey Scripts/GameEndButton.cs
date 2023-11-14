using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEndButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ�� ������ �߰�
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnExitButtonClick);
        }
    }
    void OnExitButtonClick()
    {
        // ���� ����
        Application.Quit();


    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
    #endif
    }
}
