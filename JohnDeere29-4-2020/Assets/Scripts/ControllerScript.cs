using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerScript : MonoBehaviour   //extending  // inheritance
{
    //Variables 

    //methods

    public int firstNum;  //access specifier default value is private  

    public float timer;  //0.5 , 11.10

    public string name;

    public GameObject cam;  //

    public CameraMovementScript cms; //user defined


    public void Awake()// once //  initialize
    {
        print("inside awake");
    }

    private void Start() // once //  first frame // initialize
    {
        print("inside start");

        //cms.camAnim.Play();  //Objects // class

        timer = 5.5f ;
        
        GetAddtion();

        firstNum = GetAddtion(21, 57); // Polymorphism  // OOP  // Class , Object // Inheritance // Abstraction



        //Instantiate(cam);
    }

    //prefab   //pre fabricated Gameobject

    private void Update()
    {
        cam.transform.Translate(Vector3.right);

        print("inside UPDATE");
    }

    public void FixedUpdate()
    {
        
    }

    public void GetAddtion( )// no parameters
    {
        print( "Inside get addition no params" );
    }

   int GetAddtion( int a , int b )
    {
        int temp = a + b;

        print( "Inside get addition = " + temp );

        return temp;
    }

    public void ObjectToDetroy()
    {
        
    }
}

