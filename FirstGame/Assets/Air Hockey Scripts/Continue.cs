using UnityEngine;
using UnityEngine.UI;

public class ButtonClickExample : MonoBehaviour
{

    void Start()
    {
        // 버튼 클릭 이벤트에 리스너 추가
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnButtonClick);
        }
    }

    void OnButtonClick()
    {
        

        // F10 키가 눌렸을 때 추가로 수행할 동작을 여기에 추가
    }
}