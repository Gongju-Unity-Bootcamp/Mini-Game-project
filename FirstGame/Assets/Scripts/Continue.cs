using UnityEngine;
using UnityEngine.UI;

public class ButtonClickExample : MonoBehaviour
{

    void Start()
    {
        // ��ư Ŭ�� �̺�Ʈ�� ������ �߰�
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);
        }
    }

    void OnButtonClick()
    {
        

        // F10 Ű�� ������ �� �߰��� ������ ������ ���⿡ �߰�
    }
}