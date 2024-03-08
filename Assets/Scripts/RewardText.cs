using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardText : MonoBehaviour
{
    public Text ptsText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ptsText.text =  GameObject.Find("GameMaster").GetComponent<SingletonObject>().currentReward + "pts";
    }
}
