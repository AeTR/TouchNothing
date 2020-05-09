using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPuzzleScript : PuzzleScript
{
    public MatchButton.SymbolState[] layoutArray, solutionArray;

    public MatchButton.SymbolState currentSymbol;

    public int currentKey;

    public MatchButton[] myButtons;

    public SwapButton[] mySwapArrows;

    public Animator myAnim;

    public string arrowString;

    public AudioClip phase1Sound, successTone, positive, negative;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        arrowString = "Arrow Sink";
        currentKey = 0;
        currentSymbol = solutionArray[currentKey];
    }

    public void CheckSymbolLayout()
    {
        Debug.Log("Checking");
        bool solved = true;
        for (int i = 0; i < layoutArray.Length; i++)
        {
            if (myButtons[i].mySymbol != layoutArray[i])
            {
                solved = false;
                Debug.Log("False");
                DisableEnableArrows(true);
            }
        }

        if (solved)
        {
            Debug.Log("True");
            myAnim.SetTrigger(arrowString);
            foreach (MatchButton temp in myButtons)
            {
                Debug.Log("Set to true");
                temp.pushable = true;
            }
            puzzleSource.PlayOneShot(phase1Sound);
            currentKey = 0;
        }
    }

    public void CheckSolution(MatchButton.SymbolState inputSymbol)
    {
        if (inputSymbol == solutionArray[currentKey])
        {
            Debug.Log("Correct");
            if (currentKey < 9)
            {
                currentKey++;
                puzzleSource.PlayOneShot(positive);
                Debug.Log(currentKey);
                if (currentKey <= 8)
                {
                    currentSymbol = solutionArray[currentKey];
                    Debug.Log(currentSymbol);
                }
            }
            if (currentKey >= 9)
            {
                puzzleSource.PlayOneShot(successTone);
                Debug.Log("Puzzle freakin solved");
                //puzzle solved, do the thing
                Solve();
            }
        }
        else
        {
            puzzleSource.PlayOneShot(negative);
            Debug.Log("Incorrect");
            currentKey = 0;
        }
    }

    public void DisableEnableArrows(bool which)
    {
        foreach (SwapButton temp in mySwapArrows)
        {
            temp.pushable = which;
        }
    }
}
