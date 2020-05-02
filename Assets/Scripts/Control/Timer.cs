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
        timeLeft = 120f;
        timeUp = false;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        timerText.text = Mathf.RoundToInt(timeLeft).ToString();
        if (timeLeft <= 0f && !timeUp)
        {
            timeUp = true;
            timerText.text = "Press R to Restart";
        }
        if (timeUp)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("PlayableTestScene");
            }
        }
    }
}
