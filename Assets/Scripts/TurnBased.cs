using UnityEngine;
using System.Collections;

public class TurnBased : MonoBehaviour {
	
	void alternatePlayers(){
		timeLeft = timeSet;
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0){
			gameStarted = false;
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
