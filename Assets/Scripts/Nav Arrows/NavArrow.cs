using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavArrow : MechanismScript
{
    public bool pushable;
    public ArrowPuzzle myArrowPuzzle;
    public AudioClip borderSound;
    public enum ArrowType
    {
        Left,
        Up,
        Right
    }

    public ArrowType myType;
    // Start is called before the first frame update
    void Start()
    {
        pushable = true;
    }

    public new void Interact()
    {
        if (pushable)
        {
            mySource.PlayOneShot(myInteractSound);
            myAnimator.SetTrigger(interactTrigger);
            switch (myType)
            {
                case ArrowType.Left:
                    myArrowPuzzle.shipX -= 1;
                    break;
                case ArrowType.Up:
                    myArrowPuzzle.shipY += 1;
                    break;
                case ArrowType.Right:
                    myArrowPuzzle.shipX += 1;
                    break;
            }
            myArrowPuzzle.ArrowCheck();
        }
        else
        {
            mySource.PlayOneShot(borderSound);
            Debug.Log("Can't do that!");
            
        }
    }
}
