using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMManager : MonoBehaviour
{
    static public BGMManager instance;
    AudioSource audioSource;
    public AudioClip startBGM;
    public AudioClip gameBGM;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayStartBGM()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(startBGM);
    }
    public void PlayGameBGM()
    {
        audioSource.Stop();
        audioSource.PlayOneShot(gameBGM);
    }
    public void StopBGM()
    {
        audioSource.Stop();
    }
}
