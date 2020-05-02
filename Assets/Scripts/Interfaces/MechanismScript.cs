using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The mechanism script is used by all switches, levers, and buttons. Pretty much everything interactable that isn't a tool or an obstacle.
public class MechanismScript : MonoBehaviour
{

    public Animator myAnimator;
    public string interactTrigger;
    public AudioSource mySource;
    public AudioClip myInteractSound;
    public bool oneShot; //true if animation will return to neutral after finishing.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact()
    {
        //weed
        //play an animation once and and possibly return to neutral???
        //play a frickin' cool sound effect, brother!!
        //profit
        myAnimator.SetTrigger(interactTrigger);
        InteractEvent();
        mySource.PlayOneShot(myInteractSound);
        //Debug.Log("Interacting!");
    }

    public void InteractEvent()
    {
        
    }
}
