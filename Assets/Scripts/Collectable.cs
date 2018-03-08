using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	public int speed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Rotation ();
	}

	public void Rotation(){
		gameObject.transform.Rotate (new Vector3 (30, 40, 15)* Time.deltaTime * speed);
	}
}
