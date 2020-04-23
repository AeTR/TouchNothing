using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leverAnimBehavior : MechanismScript
{
    public GameObject nextThing;
    public bool thrusted;

    void Start()
    {
        thrusted = false;
    }
    public new void Interact()
    {
        if (!thrusted)
        {
            myAnimator.SetTrigger(interactTrigger);
            nextThing.SetActive(true);
        }
    }
}
