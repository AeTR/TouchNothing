using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton : MechanismScript
{
    public int buttonNum;

    public FleetPanel fleet;

    public new void Interact()
    {
        mySource.PlayOneShot(myInteractSound);
        myAnimator.SetTrigger(interactTrigger);
        fleet.CheckFleetPuzzle(buttonNum);
    }
}
