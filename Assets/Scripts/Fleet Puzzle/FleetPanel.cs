using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleetPanel : PuzzleScript
{
    public AudioClip positiveBeep, negativeBoop, solveTone;
    public int[] properOrder;

    public int currentNum;

    public void CheckFleetPuzzle(int tempNum)
    {
        if (tempNum == properOrder[currentNum])
        {
            
            currentNum++;
            if (currentNum >= properOrder.Length && !solved)
            {
                puzzleSource.PlayOneShot(solveTone);
                Solve();
            }
            else
            {
                puzzleSource.PlayOneShot(positiveBeep);
            }
        }
        else
        {
            puzzleSource.PlayOneShot(negativeBoop);
            currentNum = 0;
        }
    }
}
