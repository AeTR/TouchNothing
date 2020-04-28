using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juiceScript : MonoBehaviour
{
    public Transform thisDestination;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(coundownCoffee());
    }

    IEnumerator coundownCoffee()
    {
        Debug.Log("WOAH");

        yield return null;

        Debug.Log("Waited for 1 frame");
        
        yield return new WaitForSeconds(1.0f);
        
        Debug.Log("3...");
        
        yield return new WaitForSeconds(1.0f);
        
        Debug.Log("2...");
        
        yield return new WaitForSeconds(1.0f);
        
        Debug.Log("1...");
        
        yield return new WaitForSeconds(1.0f);
        
        Debug.Log("Go!");
        
        //yield return new WaitForSeconds(1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += thisDestination.position - transform.position) *.1f;
    }
}
