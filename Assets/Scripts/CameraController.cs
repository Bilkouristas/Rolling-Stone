using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 distanceFromPlayer;

	// Use this for initialization
	void Start () {
		distanceFromPlayer = gameObject.transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		gameObject.transform.position = player.transform.position + distanceFromPlayer;
	}
}
