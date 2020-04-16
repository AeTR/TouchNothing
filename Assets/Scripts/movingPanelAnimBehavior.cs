using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPanelAnimBehavior : MonoBehaviour
{
    public Animator panelAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
                if (Input.GetKey(KeyCode.A)) 
                {
                    panelAnim.SetTrigger("movePanel");
                }
    }
}
