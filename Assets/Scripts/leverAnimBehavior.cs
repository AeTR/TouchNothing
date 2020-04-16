using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverAnimBehavior : MonoBehaviour
{
    public Animator switchAnim;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)) 
        {
            switchAnim.SetTrigger("pushDown");
        }
    }
}
