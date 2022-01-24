using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube1 : MonoBehaviour
{
    //creates 2 floats in order to get the directions that are needed
    public Text changText;
    public float dirX;
    public float dirZ;


    // Start is called before the first frame update
    void Start()
    {
        //initializes the spot where the new instants of the object will be
        transform.position = new Vector3(dirX, 0.69f, dirZ);

    }
    void OnCollisionEnter(Collision Other)
    {
        //destroys the game object once hit
        Destroy(this.gameObject);
        
    }
    private void FixedUpdate()
    {
        //slowly rotates the pickup objects
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
}
