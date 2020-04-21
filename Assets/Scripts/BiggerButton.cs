using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BiggerButton : MechanismScript
{

    public new void Interact()
    {
        SceneManager.LoadScene("PlaceholderWin");
    }
}
