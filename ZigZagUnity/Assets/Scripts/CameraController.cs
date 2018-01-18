using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject ball;
	private Vector3 offset;
	private float lerpRate = 2;
	public bool gameOver;

	// Use this for initialization
	void Start () {
		offset = ball.transform.position - transform.position;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameOver) {
			Follow();
		}
	}


	void Follow () {
		Vector3 cameraCurrentPos = transform.position;
		Vector3 targetPos = ball.transform.position - offset;
		cameraCurrentPos = Vector3.Lerp(cameraCurrentPos, targetPos, lerpRate * Time.deltaTime);
		transform.position = cameraCurrentPos;
	}
}
