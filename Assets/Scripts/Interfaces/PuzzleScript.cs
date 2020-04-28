using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PuzzleScript : MonoBehaviour
{
    public GameObject nextPuzzle;
    public Timer myTimer;
    public bool solved;
    // Start is called before the first frame update
    void Awake()
    {
        solved = false;
    }

    public void Solve()
    {
        solved = true;
        nextPuzzle.SetActive(true);
    }

    public void IncreaseTime(float increaseAmount)
    {
        //myTimer.timeLeft += increaseAmount;
        //myTimer.timerText.text = Mathf.RoundToInt(myTimer.timeLeft).ToString();
    }

    public void DecreaseTime(float decreaseAmount)
    {
        //Debug.Log("Decreasing");
        //myTimer.timeLeft -= decreaseAmount;
        //myTimer.timerText.text = Mathf.RoundToInt(myTimer.timeLeft).ToString();
    }
}
