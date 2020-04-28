using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public AudioSource mySource;
    public AudioClip successClip, failClip; //successClip plays when you use the correct tool, failClip plays when you use no tool or an incorrect tool
    //public Animator myAnimator;
    //public Animation successAnim; plays when you use the correct tool. Currently we will just delete the object.
    public enum WhichToolWorks
    {
        Key,
        Hammer,
        Screwdriver
    }

    public WhichToolWorks myTool;

    public void RemoveObject()
    {
        mySource.PlayOneShot(successClip);
        Destroy(gameObject);
    }
}
