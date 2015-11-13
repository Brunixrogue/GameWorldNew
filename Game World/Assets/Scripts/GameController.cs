using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameController : MonoBehaviour {

    public Text scoreText;
    private int score;

	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }


}



