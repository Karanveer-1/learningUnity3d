﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	public GameObject particle;
	[SerializeField]
	private float speed;
	private Rigidbody rigidBodyOfBall;
	private bool start;
	private bool gameOver;

	void Awake () {
		rigidBodyOfBall = GetComponent<Rigidbody>();

	}

	// Use this for initialization
	void Start () {
		start = false;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!start) {
			if (Input.GetMouseButtonDown (0)) {
				rigidBodyOfBall.velocity = new Vector3 (speed, 0, 0);
				start = true;
				GameManager.instance.StartGame();
			}
		}

		if (!Physics.Raycast (transform.position, Vector3.down, 1f)) {
			gameOver = true;
			rigidBodyOfBall.velocity = new Vector3(0, -25f, 0);
			Camera.main.GetComponent<CameraFollow>().gameOver = true;
			GameManager.instance.GameOver();
		}

		if (Input.GetMouseButtonDown(0)  && !gameOver) {
			SwitchDirection();
		}
	}

	void SwitchDirection () {
		if (rigidBodyOfBall.velocity.z > 0) {
			rigidBodyOfBall.velocity = new Vector3(speed,0,0);
		} else {
			rigidBodyOfBall.velocity = new Vector3(0,0,speed);
		}
	}

	void OnTriggerEnter (Collider col) {
		if (col.gameObject.tag == "Diamind") {
			GameObject part = Instantiate(particle,col.gameObject.transform.position,Quaternion.identity);
			Destroy(part, 1f);
			Destroy(col.gameObject);
		}
	}
}
