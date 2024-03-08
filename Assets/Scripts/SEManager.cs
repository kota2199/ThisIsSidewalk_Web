using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SEManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip positiveButton;
    public AudioClip negativeButton;
    public AudioClip parchaceButton;
    public AudioClip gameStart;
    public AudioClip gameOver;
    public AudioClip countDown;
    public AudioClip attack;
    public AudioClip miss;
    public AudioClip tutorial;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayPosiButton()
    {
        audioSource.PlayOneShot(positiveButton);
    }
    public void PlayNegaButton()
    {
        audioSource.PlayOneShot(negativeButton);
    }
    public void PlayParchaceButton()
    {
        audioSource.PlayOneShot(parchaceButton);
    }
    public void PlayGameStart()
    {
        audioSource.PlayOneShot(gameStart);
    }
    public void PlayGameOver()
    {
        audioSource.PlayOneShot(gameOver);
        GameObject.Find("BGMManager").GetComponent<AudioSource>().Stop();
    }
    public void PlayCountDown()
    {
        audioSource.PlayOneShot(countDown);
    }
    public void PlayAttack()
    {
        audioSource.PlayOneShot(attack);
    }
    public void PlayMiss()
    {
        audioSource.PlayOneShot(miss);
    }
    public void PlayTutorialSound()
    {
        audioSource.PlayOneShot(tutorial);
    }
}
