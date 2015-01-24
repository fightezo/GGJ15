using UnityEngine;
using System.Collections;

public class PlayerStart : MonoBehaviour {
	public bool houseInteract = false;
	public bool grounded = false;
	private Animator anim;
	public bool gameStarted = false;
	public float speed = 10f;
	public int id;
	public float timeSet;
//	public float timeLeft = 0f;

//	void Awake(){
//		anim = GetComponent<Animator>();
//	}

	void OnCollisionEnter(Collision hit){
		grounded = true;
	}

	// Use this for initialization
	void Start () {
		if(id % 2 == 1){
		gameStarted = true;
			timeSet = 15f;
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
		timeSet -= Time.deltaTime;
		if(timeSet < 0){
			gameStarted = false;
		}
//		if(Collision.gameObject("door") == true){
//			houseInteract = true;
//			Application.LoadLevel("ItemBuy");
//		}
	}
}
