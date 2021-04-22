using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPuzzle : PuzzleScript
{
    public SingleSwitch[] allSwitches;
    public bool[] switchSolution;

    public AudioClip successTone;
    // Start is called before the first frame update
    void Start()
    {
        solved = false;
        switchSolution = new[] {true, true, false, true, false, false, true, true, false, true};
    }

    public void CheckAllSwitches()
    {
        Debug.Log("Now checking");
        bool correct = true;
        for (int i = 0; i < 10; i++)
        {
            if (allSwitches[i].up != switchSolution[i])
            {
                correct = false;
                Debug.Log("Incorrect switch is at " + i);
            }
        }

        if (correct)
        {
            puzzleSource.PlayOneShot(successTone);
            Debug.Log("You did it!");
            Solve();
        }
        else
        {
            Debug.Log("You failed");
        }
    }
}
