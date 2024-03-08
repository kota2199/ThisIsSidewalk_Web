using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoSceneTransition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("AutoTransition");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator AutoTransition()
    {
        yield return new WaitForSeconds(5);
        string transitionscenename = GameObject.Find("GameMaster").GetComponent<FirstPlay>().sceneName;
        this.GetComponent<PanelFade>().FadeOut();
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(transitionscenename);
        GameObject.Find("BGMManager").GetComponent<BGMManager>().PlayStartBGM();
    }
}
