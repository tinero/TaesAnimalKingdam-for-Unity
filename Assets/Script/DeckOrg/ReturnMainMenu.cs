using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReturnMainMenu : MonoBehaviour
{
    

    [System.Obsolete]
    public void OnClick()
    {
        Application.LoadLevel("MainMenu");
    }
}
