using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushBigButton : MechanismScript
{
    public GameObject fleetButtons;

    public bool pressedYet;

    public Timer myTimer;
    // Start is called before the first frame update
    void Start()
    {
        pressedYet = false;
    }

    public new void Interact()
    {
        myAnimator.SetTrigger("PressingAgain");
        if (!pressedYet)
        {
            pressedYet = true;
            fleetButtons.SetActive(true);
            myTimer.timeLeft += 10f;
        }
    }
}
