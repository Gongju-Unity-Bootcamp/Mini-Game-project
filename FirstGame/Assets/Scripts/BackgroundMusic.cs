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

        DontDestroyOnLoad(gameObject); //������ ���̳Ѿ�� �������ʰ��ϴ� �ڵ�
    }

  
}