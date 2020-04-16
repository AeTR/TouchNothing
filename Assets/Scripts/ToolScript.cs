using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//The tool script is used for the three tools of the game, specifically the hammer, screwdriver, and key.
public class ToolScript : MonoBehaviour
{
    public SelectionManager.ToolState thisState;
    public bool inUse;
    // Start is called before the first frame update
    void Start()
    {
        inUse = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PickUp()
    {
        
    }
}
