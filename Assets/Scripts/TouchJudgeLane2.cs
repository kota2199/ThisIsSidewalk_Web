using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchJudgeLane2 : MonoBehaviour
{
    GameObject colObj;
    string ObjName;
    public GameObject successText;
    public GameObject gameManager;
    public GameObject explosionImages;
    Vector2 ExplosionPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PushButtonLane2()
    {
        if (colObj != null)
        {
            if (ObjName == "Bicycle")
            {
                successText.SetActive(true);
                Invoke("SuccessTextFalse", 0.4f);
                gameManager.GetComponent<Score>().AddScore();
                GameObject.Find("GameMaster").GetComponent<SEManager>().PlayAttack();
                ExplosionPos = colObj.transform.position;
                Instantiate(explosionImages, ExplosionPos, Quaternion.identity);
                Destroy(colObj);
            }
            if (ObjName == "BicycleB")
            {
                successText.SetActive(true);
                Invoke("SuccessTextFalse", 0.4f);
                gameManager.GetComponent<Score>().AddScoreB();
                GameObject.Find("GameMaster").GetComponent<SEManager>().PlayAttack();
                ExplosionPos = colObj.transform.position;
                Instantiate(explosionImages, ExplosionPos, Quaternion.identity);
                Destroy(colObj);
            }
            if (ObjName == "BicycleC")
            {
                successText.SetActive(true);
                Invoke("SuccessTextFalse", 0.4f);
                gameManager.GetComponent<Score>().AddScoreC();
                GameObject.Find("GameMaster").GetComponent<SEManager>().PlayAttack();
                ExplosionPos = colObj.transform.position;
                Instantiate(explosionImages, ExplosionPos, Quaternion.identity);
                Destroy(colObj);
            }
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bicycle")
        {
            colObj = collision.gameObject;
            ObjName = "Bicycle";
        }
        if (collision.gameObject.tag == "BicycleB")
        {
            colObj = collision.gameObject;
            ObjName = "BicycleB";
        }
        if (collision.gameObject.tag == "BicycleC")
        {
            colObj = collision.gameObject;
            ObjName = "BicycleC";
        }
        if (collision.gameObject.tag == "Walker")
        {

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bicycle")
        {
            colObj = null;
        }
        if (collision.gameObject.tag == "BicycleB")
        {
            colObj = null;
        }
        if (collision.gameObject.tag == "BicycleC")
        {
            colObj = null;
        }
    }
    public void SuccessTextFalse()
    {
        successText.SetActive(false);
    }
}