using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeAdjust : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider bgmvolumeSlider;
    private int firstDo;
    // Start is called before the first frame update
    void Start()
    {
        firstDo = PlayerPrefs.GetInt("DoCount");
        if (firstDo < 1)
        {
            volumeSlider.value = 1;
            bgmvolumeSlider.value = 1;
            firstDo++;
            PlayerPrefs.SetInt("DoCount",firstDo);
        }
        else
        {
            volumeSlider.value = PlayerPrefs.GetFloat("volume");
            bgmvolumeSlider.value = PlayerPrefs.GetFloat("bgmvolume");
        }
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("GameMaster").GetComponent<AudioSource>().volume = volumeSlider.value;
        PlayerPrefs.SetFloat("volume", GameObject.Find("GameMaster").GetComponent<AudioSource>().volume);
        PlayerPrefs.Save();
        GameObject.Find("BGMManager").GetComponent<AudioSource>().volume = bgmvolumeSlider.value;
        PlayerPrefs.SetFloat("bgmvolume", GameObject.Find("BGMManager").GetComponent<AudioSource>().volume);
    }
}
