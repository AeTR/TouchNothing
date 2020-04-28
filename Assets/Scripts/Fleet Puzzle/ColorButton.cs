using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton : MechanismScript
{
    public int buttonNum;

    public FleetPanel fleet;

    public new void Interact()
    {
        myAnimator.SetTrigger(interactTrigger);
        fleet.CheckFleetPuzzle(buttonNum);
    }
}
