using UnityEngine;
using System.Collections;

public class PlayerStart : MonoBehaviour {
	public bool houseInteract = false;
	public bool grounded = false;
	private Animator anim;
	public bool gameStarted = false;
	public float speed = 10f;
	public float timeLeft = 30.0f;
//	void Awake(){
//		anim = GetComponent<Animator>();
//	}

	void OnCollisionEnter(Collision hit){
		grounded = true;
	}

	// Use this for initialization
	void Start () {
		gameStarted = false;
	}

	// Update is called once per frame
	void Update () {

//		Check whether time is up
//		timeLeft -= Time.deltaTime;
//		if(timeLeft < 0){
//			Switch();
//		}

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

