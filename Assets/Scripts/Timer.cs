using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {
	public float timeLeft = 30.0f;
	// Use this for initialization
	void Start () {
		//Check whether time is up
		timeLeft -= Time.deltaTime;
		if(timeLeft < 0){
			//Switch();
				}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
