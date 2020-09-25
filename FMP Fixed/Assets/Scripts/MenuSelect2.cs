using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuSelect2 : MonoBehaviour
{


    // add your other menu variables here and link to them in the Unity inspector
    public GameObject menu_1;
    public GameObject menu_2;





    public static string menu = "start";
   




    // Update is called once per frame
    void Update()
    {
        // this method is called from the camera gameObject and checks to see which menu should be displayed

        Vector3 enable = new Vector3(960.0f, 540.0f, 0.0f);  // position of the menu to make it visible
        Vector3 disable = new Vector3(10000.0f, 0, 0);   // position of the menu to move it off screen

        // move the chosen menu into view and move the others off screen
        if (menu == "start1")
        {
            menu_1.transform.position = enable;     // if we have chosen to view the "start" menu, move the other menus offscreen
            menu_2.transform.position = disable;

        }
        if (menu == "pause2")
        {
            menu_1.transform.position = disable;     // if we have chosen to view the "start" menu, move the other menus offscreen
            menu_2.transform.position = enable;

        }
    }


    }




  

   


    

