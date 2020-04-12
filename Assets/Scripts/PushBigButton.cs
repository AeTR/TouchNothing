using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBigButton : MonoBehaviour
{
    public Animator myAnimator;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        myAnimator.SetBool("Pressing", Input.GetKey(KeyCode.Space));
    }

    public void PressButton()
    {
        myAnimator.SetBool("Pressing", Input.GetMouseButton(0));
    }
}
