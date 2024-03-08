using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeletePanelEffect : MonoBehaviour
{
    public float imageA;
    float red, green, blue;
    public bool flashOn;
    public bool flashOff;
    // Start is called before the first frame update
    void Start()
    {
        flashOff = false;
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
        imageA = 1;
        GetComponent<Image>().color = new Color(red, green, blue, imageA);
    }

    // Update is called once per frame
    void Update()
    {
        if (flashOn)
        {
            Debug.Log("FlashStart");
            imageA -= 0.1f;
            GetComponent<Image>().color = new Color(red, green, blue, imageA);
            if (imageA <= 0)
            {
                flashOn = false;
                flashOff = true;
            }
        }
        if (flashOff)
        {
            Debug.Log("FlashEnd");
        }
    }
}
