using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupCollider : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float timeLeft = 30.0f;
   
    void Update()
    {
    
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
            col.gameObject.transform.tag = "GodMode";
        Destroy(GameObject.FindWithTag("PowerUp"));
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log("Timer Finished");
            if (col.gameObject.CompareTag("Box1"))
            {
                col.gameObject.transform.tag = "Player";
            }
        }
    }
}
