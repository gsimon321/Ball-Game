using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    //initializes the GameObject player
    public GameObject player;
    //initializes the Vector3 that is the offset for the camera
    private Vector3 offset;

    void Start()
    {
        //creates the offset that is defined by the transform position subtracted by the players position
        offset = transform.position - player.transform.position;
    }

    
    void LateUpdate()
    {
        //adds the offset to the camera inorder to get a valid view
        transform.position = player.transform.position + offset;
    }
}
