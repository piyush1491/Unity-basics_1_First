using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private bool jumpKeywasPressed;
    private float horzontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {

            jumpKeywasPressed = true;

        }

        horzontalInput= Input.GetAxis("Horizontal");
       
    }
    // fixedupdate is    called once every physics update  
    private void FixedUpdate()
    {
      
        if(jumpKeywasPressed) 
        {
            GetComponent<Rigidbody>().isKinematic= false; 
            GetComponent<Rigidbody>().AddForce(Vector3.up *2,ForceMode.VelocityChange);
            jumpKeywasPressed= false;
            //GetComponent<Rigidbody>().isKinematic= true; 
        }
        GetComponent<Rigidbody>().velocity= new Vector3(horzontalInput* 2f,GetComponent<Rigidbody>().velocity.y,0);

    }
}



