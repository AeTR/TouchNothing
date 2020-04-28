using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapButton : MechanismScript
{
    public ButtonPuzzleScript buttonPuzzle;

    public MatchButton buttonA, buttonB, buttonC;

    public bool pushable;
    // Start is called before the first frame update
    void Start()
    {
        myAnimator = buttonPuzzle.myAnim;
        pushable = true;
    }

    public new void Interact()
    {
        if (pushable)
        {
            buttonPuzzle.DisableEnableArrows(false);
            myAnimator.SetTrigger(interactTrigger);
            SwapButtons();
        }
        //InteractEvent();
        //Debug.Log("Interacting!");
    }

    public void SwapButtons()
    {
        Material tempMat = buttonA.myMesh.material;
        buttonA.myMesh.material = buttonB.myMesh.material;
        buttonB.myMesh.material = buttonC.myMesh.material;
        buttonC.myMesh.material = tempMat;
        MatchButton.SymbolState tempSymbol = buttonA.mySymbol;
        buttonA.mySymbol = buttonB.mySymbol;
        buttonB.mySymbol = buttonC.mySymbol;
        buttonC.mySymbol = tempSymbol;
        buttonPuzzle.CheckSymbolLayout();
    }
}
