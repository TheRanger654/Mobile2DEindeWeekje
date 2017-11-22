using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public int score;
    private bool scoreAdded;

	// Use this for initialization
	void Start () {
        score = 0;
        scoreAdded = false;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(score);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ScoreAdd")
        {
            if(scoreAdded == false)
            {
                score++;
                scoreAdded = true;
            }
        }
    }
}
