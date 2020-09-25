using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitScript : MonoBehaviour
{

    public void Quit()
    {

        UnityEditor.EditorApplication.isPlaying = false;

        Application.Quit ();
        Debug.Log("Quit");

    }

}
