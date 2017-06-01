using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDeathTimer : MonoBehaviour {

	public float timeLeft = 300.0f;
	public bool stop = true;

	private float minutes;
	private float seconds;

	public void startTimer(float from){
		stop = false;
		timeLeft = from;
		Update();
	}

	void Update() {
		if(stop) return;
		timeLeft -= Time.deltaTime;

		minutes = Mathf.Floor(timeLeft / 60);
		seconds = timeLeft % 60;
		if(seconds > 59) seconds = 59;
		if(minutes < 0) {
			stop = true;
			minutes = 0;
			seconds = 0;
			gameObject.SetActive (false);
		}
		//        fraction = (timeLeft * 100) % 100;
	}
}
