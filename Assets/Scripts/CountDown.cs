using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public GameObject coutDownUI;
    private bool isSporning = false;
    public Text countDownText;
    public bool ItemOneUse;
    public bool ItemTwoUse;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("CountDownStart");
        ItemOneUse = false;
        ItemTwoUse = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator CountDownStart()
    {
        yield return new WaitForSeconds(1);
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayCountDown();
        countDownText.text = "3";
        yield return new WaitForSeconds(1);
        countDownText.text = "2";
        yield return new WaitForSeconds(1);
        countDownText.text = "1";
        yield return new WaitForSeconds(1);
        countDownText.text = "スタート！";
        isSporning = true;
        yield return new WaitForSeconds(1);
        coutDownUI.SetActive(false);
        ItemOneUse = true;
        ItemTwoUse = true;
    }
}
