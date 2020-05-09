using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchButton : MechanismScript
{
    public enum SymbolState
    {
        Symbol1,
        Symbol2,
        Symbol3,
        Symbol4,
        Symbol5,
        Symbol6,
        Symbol7,
        Symbol8,
        Symbol9
    }

    public bool pushable;
    public SymbolState mySymbol;
    public MeshRenderer myMesh;

    public ButtonPuzzleScript buttonPuzzle;
    // Start is called before the first frame update
    void Start()
    {
        myMesh = GetComponent<MeshRenderer>();
    }

    public new void Interact()
    {
        if (pushable)
        {
            mySource.PlayOneShot(myInteractSound);
            myAnimator.SetTrigger(interactTrigger);
            //InteractEvent();
            buttonPuzzle.CheckSolution(mySymbol);
        }
    }
}
