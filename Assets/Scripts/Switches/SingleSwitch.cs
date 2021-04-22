using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleSwitch : MechanismScript
{
    public bool up;

    public SwitchPuzzle mySwitchPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public new void Interact()
    {
        mySource.PlayOneShot(myInteractSound);
        myAnimator.SetTrigger(interactTrigger);
        if (up)
        {
            Debug.Log("Currently up");
            up = false;
        }
        else
        {
            Debug.Log("Currently down");
            up = true;
        }
        mySwitchPuzzle.CheckAllSwitches();
    }
}
