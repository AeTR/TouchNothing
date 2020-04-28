using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPuzzle : MonoBehaviour
{
    public bool[,] meteorArray;
    public NavArrow leftArrow, upArrow, rightArrow;
    public int shipX, shipY;

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
            Debug.Log("You frickin crashed!");
            shipX = 1;
            shipY = 0;
        }
        else
        {
            if (shipY == 6)
            {
                Debug.Log("You got it!");
                nextThing.SetActive(true);
                gameObject.SetActive(false);
            }
            else
            {
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
