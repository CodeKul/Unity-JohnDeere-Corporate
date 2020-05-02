using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour   //extending  // inheritance
{
    public Rigidbody sphereRg;

    public float temp;

    public void Start()
    {
        //sphereRg.mass = 10;

        // temp = sphereRg.mass;

        sphereRg.AddForce(new Vector3(0, 0.75f, 1) * 2000 ); //global direction
    }

    public void FixedUpdate() // physics 
    {
        // sphereRg.AddForce( Vector3.back * 10 );  // ( 0,0,-1)   (x ,y ,z )

        // sphereRg.AddForce( new Vector3(0,1,1) * 50 ); //global direction

        // sphereRg.AddRelativeForce (new Vector3(0, 0, 1) * 30); // local direction force

         // sphereRg.AddTorque(Vector3.up * 10);

        //sphereRg.AddRelativeTorque (Vector3.up * 10);

        //sphereRg.isKinematic = false;

    }
}

