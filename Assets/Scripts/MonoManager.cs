using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MonoManager : MonoBehaviour
{
    public string[] textLines;
    public AudioSource mySource;
    public AudioClip[] monologueClips;
    public Text monologueText, hintText;
    public int currentNum;
    // Start is called before the first frame update
    void Start()
    {
        currentNum = 0;
        hintText.text = "Click to continue";
        LoadMonologue();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (currentNum < 12)
            {
                currentNum++;
                LoadMonologue();
            }
            else
            {
                SceneManager.LoadScene("PlayableTestScene");
            }
        }
    }

    public void LoadMonologue()
    {
        mySource.Stop();
        if (currentNum >= 12)
        {
            hintText.text = "Click to begin!";
        }
        mySource.PlayOneShot(monologueClips[currentNum]);
        monologueText.text = textLines[currentNum];
    }
    
}
