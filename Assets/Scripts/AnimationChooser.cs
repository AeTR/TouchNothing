using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChooser : MonoBehaviour
{
    public Animator thisAnimator;
    // Start is called before the first frame update
    void Start()
    {
        thisAnimator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            thisAnimator.SetTrigger("Kyle");
        }
    }
}
