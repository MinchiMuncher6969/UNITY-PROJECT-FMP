using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene_Changer : MonoBehaviour
{
  public void changemenuscene(string scenename)
  {
 

      Application.LoadLevel(scenename);
  }
}
