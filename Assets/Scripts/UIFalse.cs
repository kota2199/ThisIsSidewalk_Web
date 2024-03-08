using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIFalse : MonoBehaviour
{
    public GameObject ShopUIs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShopTrue()
    {
        ShopUIs.SetActive(true);
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayPosiButton();
    }
    public void ShopFalse()
    {
        ShopUIs.SetActive(false);
        GameObject.Find("GameMaster").GetComponent<SEManager>().PlayNegaButton();
    }
}
