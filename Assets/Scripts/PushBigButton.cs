using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBigButton : MechanismScript
{
    public GameObject fleetButtons;

    public bool pressedYet;
    // Start is called before the first frame update
    void Start()
    {
        pressedYet = false;
    }

    // Update is called once per frame
    void Update()
    {
        //myAnimator.SetBool("Pressing", Input.GetKey(KeyCode.Space));
    }

    public void Interact()
    {
        myAnimator.SetTrigger("PressingAgain");
        if (!pressedYet)
        {
            pressedYet = true;
            fleetButtons.SetActive(true);
        }
    }
}
