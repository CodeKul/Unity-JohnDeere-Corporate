using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public Transform playerTransform;

    public float xpos, ypos, zpos , yRot , xScale , yScale , zScale;

    public void Start()
    {
        xpos = 0;
        ypos = 1.5f;
        zpos = -2;
        yRot = 0;
        xScale = 2;
        yScale = 2;
        zScale = 2;
    }

    public void Update()
    {
        zpos = zpos + 0.2f;
        yRot = yRot + 10;

        xScale = xScale + 0.1f;
        yScale = yScale + 0.1f;
        zScale = zScale + 0.1f;

        playerTransform.position = new Vector3 (xpos, ypos, zpos );

        playerTransform.rotation = Quaternion.Euler(new Vector3(0, yRot, 0));

        playerTransform.localScale = new Vector3( xScale , yScale , zScale) ;   

    }


}
