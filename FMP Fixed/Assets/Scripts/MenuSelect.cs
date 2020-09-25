using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSelect : MonoBehaviour
{


    // add your other menu variables here and link to them in the Unity inspector
    public GameObject menu_1;
    public GameObject menu_2;
    public GameObject menu_3;
    public GameObject menu_4;
    public GameObject menu_5;
    public GameObject menu_6;




    public AudioSource audioSource1;    // this is the background music source
    public AudioSource audioSource2;    // sound effects audio source
    public AudioClip bgMusic;
    public AudioClip sfx1;
    public static string menu = "start";
    public static bool playSfx = false;



    // Update is called once per frame
    void Update()
    {
        // this method is called from the camera gameObject and checks to see which menu should be displayed
    
            Vector3 enable = new Vector3(0.0f, 0.0f, 1.0f);  // position of the menu to make it visible
        Vector3 disable = new Vector3(1000.0f, 0, 0);   // position of the menu to move it off screen

        // move the chosen menu into view and move the others off screen
        if (menu == "start")
        {
            menu_1.transform.position = enable;     // if we have chosen to view the "start" menu, move the other menus offscreen
            menu_2.transform.position = disable;
            menu_3.transform.position = disable;
            menu_4.transform.position = disable;
            menu_5.transform.position = disable;
            menu_6.transform.position = disable;
          
        }

        if (menu == "soundfx")
        {
            menu_1.transform.position = disable;    // if we have chosen to view the "options" menu, move the other menus offscreen
            menu_2.transform.position = enable;
            menu_3.transform.position = disable;
            menu_4.transform.position = disable;
            menu_5.transform.position = disable;
            menu_6.transform.position = disable;
            
        }

        if (menu == "difficulty")
        {
            menu_1.transform.position = disable;    // if we have chosen to view the "options" menu, move the other menus offscreen
            menu_2.transform.position = disable;
            menu_3.transform.position = disable;
            menu_4.transform.position = disable;
            menu_5.transform.position = enable;
            menu_6.transform.position = disable;
            

        }
        if (menu == "controls")
        {
            menu_1.transform.position = disable;    // if we have chosen to view the "options" menu, move the other menus offscreen
            menu_2.transform.position = disable;
            menu_3.transform.position = enable;
            menu_4.transform.position = disable;
            menu_5.transform.position = disable;
            menu_6.transform.position = disable;
            

        }
        if (menu == "options")
        {
            
            menu_1.transform.position = disable;    // if we have chosen to view the "options" menu, move the other menus offscreen
            menu_2.transform.position = disable;
            menu_2.transform.position = disable;
            menu_3.transform.position = disable;
            menu_4.transform.position = enable;
            menu_5.transform.position = disable;
            menu_6.transform.position = disable;
            
        }
        if (menu == "play")
        {
            menu_1.transform.position = disable;    // if we have chosen to view the "options" menu, move the other menus offscreen
            menu_2.transform.position = disable;
            menu_2.transform.position = disable;
            menu_3.transform.position = disable;
            menu_4.transform.position = disable;
            menu_5.transform.position = disable;
            menu_6.transform.position = enable;
            
        }







        // set the volume level from the slider variable
        audioSource1.volume = UIscript.musicVol;

        // check if the global variable playSfx is set to true. If it is, play the sound effect
        if (playSfx == true)
        {
            audioSource2.PlayOneShot(sfx1, UIscript.sfxVol);       // play the sound effect at the volume set it the slider variable
            playSfx = false;
        }
    }
    

    }






