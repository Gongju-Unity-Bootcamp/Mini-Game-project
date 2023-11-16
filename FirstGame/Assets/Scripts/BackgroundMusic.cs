using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    public AudioClip bgmClip;
    private AudioSource bgmSource;

    void Start()
    {

        bgmSource = gameObject.AddComponent<AudioSource>();
        bgmSource.clip = bgmClip;
        bgmSource.Play();

        DontDestroyOnLoad(gameObject); //음악이 씬이넘어가도 끊기지않게하는 코드
    }

  
}