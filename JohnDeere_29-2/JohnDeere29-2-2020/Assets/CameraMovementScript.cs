using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovementScript : MonoBehaviour
{
    public Transform cam;
    public Transform target;
    public int speed , index , rotationSpeed;

    public List<Transform> wayPoints;
    
    public int[] speeds;

    public float distance;

    public Animation camAnim;

    public AudioSource sound;

    void Start()
    {
        camAnim.Play();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (!sound.isPlaying )
        {
            if (Input.GetMouseButtonDown(0))
            {
                sound.Play();
            }
        }

        if ( !camAnim.isPlaying )
        {
            distance = Vector3.Distance(cam.position, target.position);

            if (distance < 0.5f)
            {
                if (index < (wayPoints.Count - 1))
                {
                    index++;
                }

                target = wayPoints[index];
            }

            cam.position = Vector3.MoveTowards(cam.position, target.position, Time.deltaTime * speed);

            cam.Rotate(Vector3.up * rotationSpeed * Input.GetAxis("Mouse X") * Time.deltaTime);

        }
                
    }
}
