using UnityEngine;
using System.Collections;

public class PlayerStart : MonoBehaviour {
	public bool grounded = false;		//whether the player is on the floor
	public bool gameStarted = false;	//whether the prospective player has started his turn
	public float speed = 10f;			//default speed of moving
	public int id;						//player ids to separate between 1 and 2
	public float timeSet;				//sets the time limit per person			
	private bool gameStateEnd = false;	//check whether the game has ended
	private float timeLeft;
	
	void OnCollisionEnter(Collision hit){
		grounded = true;
	}
	
	// Use this for initialization
	void Start () {
		// Player1 goes first
		if(id == 1){
			gameStarted = true;
			}
	}


	// Update is called once per frame
	void Update () {	

		if(Input.GetButton("Forward")){
			if((grounded == true) && (gameStarted == true)){
				rigidbody.MovePosition(rigidbody.position + Vector3.forward * speed * Time.deltaTime);
			}
		}

		if(Input.GetButton("Backward")){
			if((grounded == true) && (gameStarted == true)){
				rigidbody.MovePosition(rigidbody.position - Vector3.forward * speed * Time.deltaTime);
			}
		}

		if(Input.GetButton("Right")){
			if((grounded == true) && (gameStarted == true)){
				rigidbody.MovePosition(rigidbody.position + Vector3.right * speed * Time.deltaTime);
			}
		}

		if(Input.GetButton("Left")){
			if((grounded == true) && (gameStarted == true)){
				rigidbody.MovePosition(rigidbody.position - Vector3.right * speed * Time.deltaTime);
			}
		}
	}

}
