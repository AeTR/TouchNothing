using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPuzzle : PuzzleScript
{
    public bool[,] meteorArray;
    public NavArrow leftArrow, upArrow, rightArrow;
    public int shipX, shipY;
    public AudioClip resetClip, successClip, moveClip;

    public GameObject nextThing;
    // Start is called before the first frame update
    void Start()
    {
        meteorArray = new bool[4,7];
        for (int x = 0; x < 4; x++)
        {
            for (int y = 0; y < 7; y++)
            {
                meteorArray[x, y] = false;
            }
        }
        meteorArray[0, 0] = true;
        meteorArray[3, 1] = true;
        meteorArray[1, 2] = true;
        meteorArray[0, 3] = true;
        meteorArray[2, 3] = true;
        meteorArray[0, 5] = true;
        meteorArray[2, 5] = true;
        meteorArray[3, 5] = true;
        shipX = 1;
        shipY = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ArrowCheck()
    {
        if (meteorArray[shipX, shipY])
        {
            puzzleSource.PlayOneShot(resetClip);
            Debug.Log("You frickin crashed!");
            shipX = 1;
            shipY = 0;
        }
        else
        {
            if (shipY == 6)
            {
                puzzleSource.PlayOneShot(successClip);
                Debug.Log("You got it!");
                Solve();
                leftArrow.pushable = false;
                rightArrow.pushable = false;
                upArrow.pushable = false;
            }
            else
            {
                puzzleSource.PlayOneShot(moveClip);
                if (shipX == 0)
                {
                    leftArrow.pushable = false;
                }
                else
                {
                    leftArrow.pushable = true;
                }

                if (shipX == 3)
                {
                    rightArrow.pushable = false;
                }
                else
                {
                    rightArrow.pushable = true;
                }
            }
        }
    }
}
