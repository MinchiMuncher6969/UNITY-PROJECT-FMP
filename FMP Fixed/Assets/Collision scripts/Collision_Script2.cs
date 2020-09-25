using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision_Script2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Collision detected");
            Destroy(col.gameObject);
            Application.LoadLevel("Death screen2");
        }
    }
}
