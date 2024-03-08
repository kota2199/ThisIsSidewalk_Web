using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BicycleAChangeImage : MonoBehaviour
{
    public Sprite imageOne;
    public Sprite imageTwo;
    public Sprite imageThree;
    public Sprite imageFour;
    private Sprite myImage;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ChangeSprite");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator ChangeSprite()
    {
        while (true)
        {
            GetComponent<SpriteRenderer>().sprite = imageOne;
            yield return new WaitForSeconds(0.4f);
            GetComponent<SpriteRenderer>().sprite = imageTwo;
            yield return new WaitForSeconds(0.4f);
            GetComponent<SpriteRenderer>().sprite = imageThree;
            yield return new WaitForSeconds(0.4f);
            GetComponent<SpriteRenderer>().sprite = imageFour;
            yield return new WaitForSeconds(0.4f);
        }
    }
}
