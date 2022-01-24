using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using UnityEngine.SceneManagement;

public class NewSphereMovement : MonoBehaviour
{
    //creates a speed that can be changed in the Unity IDE
    public float speed = 0;
    
  

    // Start is called before the first frame update
    void Start()
    {

    }
    
    void OnCollisionEnter(Collision Other)
    {
        //code for the scoring
        if (Other.gameObject.tag.Equals("PickUpCube")){
            //if a cube is picked up the score value will increase by 5
            
            ScoreCounter.scoreValue += 5;
            
        }
        if (Other.gameObject.tag.Equals("PickUpCylinder"))
        {
            //if its a cylinder than it will increase by 10

            ScoreCounter.scoreValue += 10;
            
        }
    }

    void restart()
    {
        //this will restart the scene once it is invoked
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Update is called once per frame
    void Update()
    {
        //constantly checking if all of the objects have been picked up
        if(ScoreCounter.scoreValue == 100)
        {
            //if this condition is met and all of the objects have been picked up it will restart with a short pause
            Invoke("restart", 5.0f);
            //resets the score to 0
            ScoreCounter.scoreValue = 0;
        }
    }
    
    void FixedUpdate()
    {
        //creates the physics for the movement of the ball
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // 3-d vector of the movement
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        //adds the movement to the rigid body
        GetComponent<Rigidbody>().AddForce(movement * speed);
    }
}
