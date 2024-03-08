using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeStep : MonoBehaviour
{
    public Text tutorialText;
    private GameObject manager;
    public GameObject sporner_L;
    public GameObject sporner_S;
    public GameObject sporner_R;
    public GameObject[] bicycleA;
    public GameObject[] bicycleB;
    public GameObject[] bicycleC;
    public GameObject walker;
    private GameObject InstPlace;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Step");
        StartCoroutine("WalkerMove");
        manager = GameObject.Find("GameMaster");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator Step()
    {
        yield return new WaitForSeconds(4);
        tutorialText.text = "このゲームについて簡単に説明します！";
        manager.GetComponent<SEManager>().PlayTutorialSound();
        yield return new WaitForSeconds(4);
        tutorialText.text = "このゲームは上から降りてくる\n歩道を走る自転車を撃退するゲームです。";
        manager.GetComponent<SEManager>().PlayTutorialSound();
        yield return new WaitForSeconds(4);
        tutorialText.text = "画面下の3つの黒いボタンの中に\n自転車が入った時にボタンを押すと\n得点が入ります！";
        manager.GetComponent<SEManager>().PlayTutorialSound();
        yield return new WaitForSeconds(4);
        tutorialText.text = "さっそくやってみましょう！";
        yield return new WaitForSeconds(3);
        Instantiate(bicycleA[1],sporner_S.transform.position,Quaternion.identity);
        yield return new WaitForSeconds(2);
        Instantiate(bicycleA[1], sporner_S.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(2);
        Instantiate(bicycleA[1], sporner_S.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5);
        tutorialText.text = "タッチのタイミングが遅れると、自身のHPが減り、\nHPがゼロになるとゲーム終了となります！";
        manager.GetComponent<SEManager>().PlayTutorialSound();
        yield return new WaitForSeconds(4);
        tutorialText.text = "撃退した自転車に応じてスコアが加算され、\nそのスコアでアイテムを購入することが出来ます！";
        manager.GetComponent<SEManager>().PlayTutorialSound();
        yield return new WaitForSeconds(4);
        tutorialText.text = "ストア画面からご確認ください！";
        manager.GetComponent<SEManager>().PlayTutorialSound();
        yield return new WaitForSeconds(4);
        tutorialText.text = "また、自転車には種類があり、\nそれぞれ速度や出現頻度、\n撃退した際に得られるスコアが異なります！";
        manager.GetComponent<SEManager>().PlayTutorialSound();
        yield return new WaitForSeconds(5);
        Instantiate(bicycleB[0], sporner_L.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        Instantiate(bicycleC[2], sporner_R.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1);
        Instantiate(bicycleB[1], sporner_S.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5);
        tutorialText.text = "チュートリアルは以上です！\nこのチュートリアルは設定から\nいつでも見ることが出来ます！";
        manager.GetComponent<SEManager>().PlayTutorialSound();
        yield return new WaitForSeconds(4);
        tutorialText.text = "これからも「ここは歩道やぞ！」を\nよろしくお願いします！";
        manager.GetComponent<SEManager>().PlayTutorialSound();
        yield return new WaitForSeconds(4);
        GetComponent<PanelFade>().FadeOut();
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Start");
    }
    private IEnumerator WalkerMove()
    {
        while (true)
        {
            float waittime = Random.Range(3,5);
            yield return new WaitForSeconds(waittime);
            int InstPlaceJud = Random.Range(1,4);
            if (InstPlaceJud == 1)
            {
                InstPlace = sporner_L;
            }
            if (InstPlaceJud == 2)
            {
                InstPlace = sporner_S;
            }
            if (InstPlaceJud == 3)
            {
                InstPlace = sporner_R;
            }
            Instantiate(walker, InstPlace.transform.position,Quaternion.identity);
        }
    }
}
