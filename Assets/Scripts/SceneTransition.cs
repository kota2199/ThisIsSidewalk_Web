using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string sceneName;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeScene()
    {
        Invoke("Transition",1);
    }
    public void Transition()
    {
        SceneManager.LoadScene(sceneName);
        if (SceneManager.GetActiveScene().name == "Start")
        {
            GameObject.Find("BGMManager").GetComponent<BGMManager>().PlayGameBGM();
        }
        if (SceneManager.GetActiveScene().name == "Main")
        {
            GameObject.Find("BGMManager").GetComponent<BGMManager>().PlayStartBGM();
        }
    }
    public void Retry()
    {
        Invoke("GameRetry",1);
    }
    public void GameRetry()
    {
        SceneManager.LoadScene("Main");
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayPosiButton();
    }
    public void PlayStartGameSE()
    {
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayGameStart();
    }
    public void ToTutorialFade()
    {
        GameObject.Find("FadeSystem").GetComponent<PanelFade>().FadeOut();
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayPosiButton();
        Invoke("ToTutorial",0.5f);
    }
    public void ToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
}
