using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DeleteThis");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator DeleteThis()
    {
        yield return new WaitForSeconds(1);
        Destroy(this.gameObject);
    }
}