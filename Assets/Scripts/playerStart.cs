using UnityEngine;
using System.Collections;

public class playerStart : MonoBehaviour {
	public bool houseInteract = false;
	public bool grounded = false;
	private Animator anim;
	public bool gameStarted = false;

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

		if(Input.GetButtonDown ("Forward")){
			if((grounded == true) && (gameStarted == true)){
				Vector3 newpos = new Vector3(0f,0f,0.3f);
				rigidbody.MovePosition(rigidbody.position - newpos);
			}
		}
		if(Input.GetButtonDown ("Backward")){
			if((grounded == true) && (gameStarted == true)){
				Vector3 newpos = new Vector3(0f,0f,0.3f);
				rigidbody.MovePosition(rigidbody.position + newpos);
			}
		}
		if(Input.GetButtonDown ("Left")){
			if((grounded == true) && (gameStarted == true)){
				Vector3 newpos = new Vector3(0.3f,0f,0f);
				rigidbody.MovePosition(rigidbody.position - newpos);
			}
		}
		if(Input.GetButtonDown ("Right")){
			if((grounded == true) && (gameStarted == true)){
				Vector3 newpos = new Vector3(0.3f,0f,0f);
				rigidbody.MovePosition(rigidbody.position + newpos);
			}
		}
//		if(Input.GetButtonDown ("Horizontal")){
//			if(grounded == true) && (gameStarted == true)){
//				Vector3 newpos = new Vector3(0,0,1);
//				rigidbody.MovePosition(rigidbody.position - newpos);
//			}
//		}
	}

}

