using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialJudger : MonoBehaviour
{
    private GameObject colObj;
    public GameObject successText;
    public GameObject explosionImages;
    public string ObjName;
    Vector2 ExplosionPos;
    // Start is called before the first frame update
    void Start()
    {
        colObj = null;
    }

    public void Touch()
    {
        if (colObj != null)
        {
            if (ObjName == "Bicycle")
            {
                successText.SetActive(true);
                Invoke("SucTextFalse", 0.4f);
                GameObject.Find("GameMaster").GetComponent<SEManager>().PlayAttack();
                ExplosionPos = colObj.transform.position;
                Instantiate(explosionImages, ExplosionPos, Quaternion.identity);
                Destroy(colObj);
            }
            if (ObjName == "BicycleB")
            {
                successText.SetActive(true);
                Invoke("SucTextFalse", 0.4f);
                GameObject.Find("GameMaster").GetComponent<SEManager>().PlayAttack();
                ExplosionPos = colObj.transform.position;
                Instantiate(explosionImages, ExplosionPos, Quaternion.identity);
                Destroy(colObj);
            }
            if (ObjName == "BicycleC")
            {
                successText.SetActive(true);
                Invoke("SucTextFalse", 0.4f);
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
            colObj = null;
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
    public void SucTextFalse()
    {
        successText.SetActive(false);
    }
}
