using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FleetPanel : MonoBehaviour
{
    public int[] properOrder;

    public int currentNum;

    public GameObject nextThing;

    public bool solvedYet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckFleetPuzzle(int tempNum)
    {
        if (tempNum == properOrder[currentNum])
        {
            currentNum++;
            if (currentNum >= properOrder.Length && !solvedYet)
            {
                nextThing.SetActive(true);
            }
        }
        else
        {
            currentNum = 0;
        }
    }
}
