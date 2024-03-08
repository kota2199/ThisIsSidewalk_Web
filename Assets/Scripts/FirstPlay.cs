using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstPlay : MonoBehaviour
{
    private int FirstStartNum;
    private bool FirstStart;
    public string sceneName;

    [SerializeField]
    private Text nextSceneTxt;
    // Start is called before the first frame update
    void Start()
    {
        FirstStartNum = PlayerPrefs.GetInt("First", FirstStartNum);
        if (FirstStartNum == 1)
        {
            sceneName = "Start";
        }
        if (FirstStartNum == 0)
        {
            sceneName = "Tutorial";
            FirstStartNum++;
            PlayerPrefs.SetInt("First", FirstStartNum);
            PlayerPrefs.Save();
        }
        nextSceneTxt.text = "Scene:" + sceneName;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.P))
        {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
        }
    }
}
