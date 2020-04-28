using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public bool timeUp;

    public Text timerText;

    public float timeLeft;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = 30f;
        timeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!timeUp)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0f)
            {
                timeUp = true;
                timerText.text = "Press R to Restart";
            }
            else
            {
                timerText.text = Mathf.RoundToInt(timeLeft).ToString();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("PlayableTestScene");
            }
        }
    }
}
