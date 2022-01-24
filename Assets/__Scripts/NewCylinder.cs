using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NewCylinder : MonoBehaviour
{ 
    //initializes two directions
    public float dirX;
    public float dirZ;
    

    // Start is called before the first frame update
    void Start()
    {
        //initializes where the new instance will start
        transform.position = new Vector3(dirX, 0.69f, dirZ);

    }
    void OnCollisionEnter(Collision Other)
    {
        //destroys the object once a collision is detected
        Destroy(this.gameObject); 
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        //rotates the pickup object
        transform.Rotate(0, 0, 50 * Time.deltaTime);
    }
}
