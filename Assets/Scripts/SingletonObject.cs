using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonObject : MonoBehaviour
{
    static public SingletonObject instance;
    private int gotReward;
    public int currentReward;
    private bool addScore;
    public int ItemOneNum;
    public int ItemTwoNum;
    // Start is called before the first frame update
    void Start()
    {
        currentReward = PlayerPrefs.GetInt("CuurentReward");
        ItemOneNum = PlayerPrefs.GetInt("ItemOneNumber");
        ItemTwoNum = PlayerPrefs.GetInt("ItemTwoNumber");
        Time.timeScale = 1;
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        addScore = true;

    }
    void Update()
    {

    }
    public void TotalizeReward()
    {
        if (addScore)
        {
            gotReward = GameObject.Find("GameManager").GetComponent<Score>().reward;
            currentReward += gotReward;
            PlayerPrefs.SetInt("CuurentReward", currentReward);
            PlayerPrefs.Save();
            addScore = false;
        }
    }
    public void BuyItemOne()
    {
        ItemOneNum++;
        PlayerPrefs.SetInt("ItemOneNumber",ItemOneNum);
        currentReward -= 500;
        PlayerPrefs.SetInt("CuurentReward", currentReward);
        PlayerPrefs.Save();
    }
    public void BuyItemTwo()
    {
        ItemTwoNum++;
        PlayerPrefs.SetInt("ItemTwoNumber", ItemTwoNum);
        currentReward -= 1000;
        PlayerPrefs.SetInt("CuurentReward", currentReward);
        PlayerPrefs.Save();
    }
}
