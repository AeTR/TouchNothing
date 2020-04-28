using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleetPanel : PuzzleScript
{
    public int[] properOrder;

    public int currentNum;

    public void CheckFleetPuzzle(int tempNum)
    {
        if (tempNum == properOrder[currentNum])
        {
            currentNum++;
            if (currentNum >= properOrder.Length && !solved)
            {
                Solve();
                IncreaseTime(15f);
                gameObject.SetActive(false);
            }
        }
        else
        {
            DecreaseTime(3f);
            currentNum = 0;
        }
    }
}
