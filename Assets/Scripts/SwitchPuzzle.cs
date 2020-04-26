﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchPuzzle : MonoBehaviour
{
    public SingleSwitch[] allSwitches;
    public GameObject nextThing;
    public bool[] switchSolution;
    // Start is called before the first frame update
    void Start()
    {
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
            }
        }

        if (correct)
        {
            Debug.Log("You did it!");
            nextThing.SetActive(true);
            gameObject.SetActive(false);
            //do a thing
        }
        else
        {
            Debug.Log("You failed");
        }
    }
}