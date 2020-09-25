using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine_col : MonoBehaviour
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
            Debug.Log("Finish");
            Destroy(col.gameObject);
            Application.LoadLevel("Finish menu");
        }
    }
}
