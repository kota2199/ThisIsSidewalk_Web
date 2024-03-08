using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text resultText;
    public Slider hpBar;
    public GameObject bestScoreText;
    private int hp;
    private int score;
    private int bestScore;
    public int reward;
    private bool isFinish = false;
    public GameObject missText;
    public GameObject gameOverUIs;
    public bool isSporning = true;
    public Text rewardText;
    private bool gameOverFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        hp = 5;
        bestScore =  PlayerPrefs.GetInt("BestScore");
    }

    // Update is called once per frame
    void Update()
    {
        isFinish = false;
        scoreText.text = "Score : " + score.ToString();
        hpBar.value = hp;
        if (hp <= 0)
        {
            if (!gameOverFlag)
            {
                gameOverFlag = true;
                gameOverUIs.SetActive(true);
                reward = score * 10;
                rewardText.text = "Reward : " + reward.ToString();
                GameObject.Find("GameMaster").GetComponent<SingletonObject>().TotalizeReward();
                GameObject.Find("GameMaster").GetComponent<SEManager>().PlayGameOver();
                resultText.text = score.ToString() + "pts";
            }
            if (bestScore > score)
            {
                bestScoreText.SetActive(true);
                bestScore = score;
                PlayerPrefs.SetInt("BestScore",bestScore);
                PlayerPrefs.Save();
            }
            GameObject[] bicycle = GameObject.FindGameObjectsWithTag("Bicycle");
            foreach (GameObject bicy in bicycle)
            {
                Destroy(bicy);
                isSporning = false;
            }
            GameObject[] bicycleb = GameObject.FindGameObjectsWithTag("BicycleB");
            foreach (GameObject bicyb in bicycleb)
            {
                Destroy(bicyb);
                isSporning = false;
            }
            GameObject[] bicyclec = GameObject.FindGameObjectsWithTag("BicycleC");
            foreach (GameObject bicyc in bicyclec)
            {
                Destroy(bicyc);
                isSporning = false;
            }
            GameObject[] walker = GameObject.FindGameObjectsWithTag("Walker");
            foreach (GameObject wal in walker)
            {
                Destroy(wal);
                isSporning = false;
            }
        }
    }
    public void AddScore()
    {
        score++;
    }
    public void AddScoreB()
    {
        score += 2;
    }
    public void AddScoreC()
    {
        score += 5;
    }
    public void DeclineScore()
    {
        hp--;
        missText.SetActive(true);
        Invoke("MissTextFalse", 0.4f);
    }
    public void MissTextFalse()
    {
        missText.SetActive(false);
    }
    public void GameOver()
    {
        
    }
}
