using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarryMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody2D PlayerRb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.W)) //if D is pressed
        {
            // Move the object upward in world space 1 unit/second.
            transform.Translate(Vector3.up * Time.deltaTime, Space.World);

        }

        if (Input.GetKey(KeyCode.S)) //if A is pressed
        {
     // Move the object upward in world space 1 unit/second.
            transform.Translate(Vector3.down* Time.deltaTime, Space.World);
            
        }
        if (Input.GetKey(KeyCode.A)) //if D is pressed
        {
     // Move the object upward in world space 1 unit/second.
            transform.Translate(Vector3.left* Time.deltaTime, Space.World);
            
        }
        if (Input.GetKey(KeyCode.D)) //if A is pressed
        {
     // Move the object upward in world space 1 unit/second.
            transform.Translate(Vector3.right* Time.deltaTime, Space.World);
           
        }
    }
}
