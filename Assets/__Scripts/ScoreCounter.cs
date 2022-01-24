using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour
{
    // instantiates a new score value
    public static int scoreValue = 0;
    //instantiates a new score
    public Text score = null;

    // Start is called before the first frame update
    void Start()
    {
        //creates the score
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        //every frame it will update with the new score
        score.text = "Score: " + scoreValue;
    }
}
