using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	private Rigidbody rigidBody;
	public float speed = 2.0f;

	public int score;
	public int maxScore;
	public int health = 5;

	public Text text;

	// Use this for initialization
	void Start () {
		rigidBody = gameObject.GetComponent<Rigidbody> ();
		text.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (score >= maxScore) {
			print ("You won");
			text.text = "You won";
			text.enabled = true;
		}
		else if (health <= 0) {
			text.text = "You lost";
			text.enabled = true;
		}
	}

	void FixedUpdate(){
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (horizontal, 0, vertical);

		rigidBody.AddForce (movement * speed);
	}

	void OnCollisionEnter(Collision obj){
		if (obj.gameObject.tag == "Damager") {
			health--;
		}
	}

	void OnTriggerEnter(Collider obj){
		if (obj.tag == "Collectable") {
			score++;
			obj.gameObject.SetActive (false);	
		}
	}

}
