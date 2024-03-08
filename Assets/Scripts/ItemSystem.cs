using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSystem : MonoBehaviour
{
    [SerializeField]
    private GameObject shopUI, itemOneCheckUI, itemTwoCheckUI, cantBuyUI;

    bool shopUIStatus = false;
    
    public void SelectItemOne()
    {
        itemOneCheckUI.SetActive(true);
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayPosiButton();
    }
    public void SelectItemTwo()
    {
        itemTwoCheckUI.SetActive(true);
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayPosiButton();
    }
    public void BuyItemOne()
    {
        GameObject gamemaster = GameObject.Find("GameMaster");
        if (gamemaster.GetComponent<SingletonObject>().currentReward >= 500)
        {
            gamemaster.GetComponent<SingletonObject>().BuyItemOne();
            itemOneCheckUI.SetActive(false);
            GameObject.Find("GameMaster").GetComponent<SEManager>().PlayParchaceButton();
        }
        else
        {
            cantBuyUI.SetActive(true);
            GameObject.Find("GameMaster").GetComponent<SEManager>().PlayNegaButton();
        }
    }
    public void BuyItemTwo()
    {
        GameObject gamemaster = GameObject.Find("GameMaster");
        if (gamemaster.GetComponent<SingletonObject>().currentReward >= 1000)
        {
            gamemaster.GetComponent<SingletonObject>().BuyItemTwo();
            itemTwoCheckUI.SetActive(false);
            GameObject.Find("GameMaster").GetComponent<SEManager>().PlayParchaceButton();
        }
        else
        {
            cantBuyUI.SetActive(true);
            GameObject.Find("GameMaster").GetComponent<SEManager>().PlayNegaButton();
        }
    }
    public void CancelItemOne()
    {
        itemOneCheckUI.SetActive(false);
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayNegaButton();
    }
    public void CancelItemTwo()
    {
        itemTwoCheckUI.SetActive(false);
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayNegaButton();
    }
    public void CantBuyOK()
    {
        cantBuyUI.SetActive(false);
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayPosiButton();
    }

    public void SwitchShopUIVisivilty()
    {
        if (shopUIStatus)
        {
            shopUI.SetActive(false);
            shopUIStatus = false;
        }
        else
        {
            shopUI.SetActive(true);
            shopUIStatus = true;
        }
    }
}
