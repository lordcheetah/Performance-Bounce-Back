using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
	private Text text;
	private int lastScore = 0;
	private int score = 0;
	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		text = GetComponentInChildren<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		score = gameManager.score;

		if (score != lastScore)
		{
			text.text = "Score: " + score.ToString ();
			lastScore = score;
		}
	}
}
