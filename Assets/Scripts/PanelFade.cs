using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PanelFade : MonoBehaviour
{
    float speed = 0.05f;  //透明化の速さ
    float inAlfa, outAlfa;
    float inRed, inGreen, inBlue;
    float outRed, outGreen, outBlue;    //RGBを操作するための変数

    private bool isFadeIn;
    private bool isFadeOut;

    public GameObject fadeInPanel;
    public GameObject fadeOutPanel;
    // Start is called before the first frame update
    void Start()
    {
        //out
        outRed = fadeOutPanel.GetComponent<Image>().color.r;
        outGreen = fadeOutPanel.GetComponent<Image>().color.g;
        outBlue = fadeOutPanel.GetComponent<Image>().color.b;
        outAlfa = 0;
        fadeOutPanel.GetComponent<Image>().color = new Color(outRed, outGreen, outBlue, outAlfa);

        //in
        inRed = fadeInPanel.GetComponent<Image>().color.r;
        inGreen = fadeInPanel.GetComponent<Image>().color.g;
        inBlue = fadeInPanel.GetComponent<Image>().color.b;
        inAlfa = 1;
        fadeInPanel.GetComponent<Image>().color = new Color(outRed, outGreen, outBlue, inAlfa);

        StartCoroutine("FadeIn");
    }

    // Update is called once per frame
    void Update()
    {
        if (isFadeIn == true)
        {
            fadeInPanel.GetComponent<Image>().color = new Color(inRed, inGreen, inBlue, inAlfa);
            inAlfa -= speed;

        }
        if (isFadeOut == true)
        {
            fadeOutPanel.GetComponent<Image>().color = new Color(outRed, outGreen, outBlue, outAlfa);
            outAlfa += speed;
        }
    }
    public void FadeOut()
    {
        fadeOutPanel.SetActive(true);
        isFadeOut = true;
    }
    private IEnumerator FadeIn()
    {
        isFadeIn = true;
        yield return new WaitForSeconds(0.8f);
        isFadeIn = false;
        fadeInPanel.SetActive(false);
    }
}
