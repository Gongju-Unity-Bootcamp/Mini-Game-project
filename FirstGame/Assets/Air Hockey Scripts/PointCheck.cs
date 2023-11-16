using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PointCheck : MonoBehaviour
{
    public GameObject SoundCheck;
    public static bool EffectSoundswitch = false;
    // Start is called before the first frame update

    void Start()
    {
        Button button = GetComponent<Button>();
        if (button != null)
        {
            button.onClick.AddListener(OnExitButtonClick);
        }
        SoundCheck.SetActive(EffectSoundswitch);


    }
    void OnExitButtonClick()
    {
        //클릭할때마다 소리껏다킴
        if (EffectSoundswitch == false)
        {
            EffectSoundswitch = true;
            SoundCheck.SetActive(EffectSoundswitch);
            AudioListener.volume = 0f;
        }
        else
        {
            EffectSoundswitch = false;
            SoundCheck.SetActive(EffectSoundswitch);
            AudioListener.volume = 1f;
        }
        
    }

}
