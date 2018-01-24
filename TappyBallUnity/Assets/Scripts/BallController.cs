using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	private Rigidbody2D rb;
	public float upForce;
	bool started;
	bool gameOver;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		started = false;
		gameOver = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!started) {
			if (Input.GetMouseButtonDown (0)) {
				started = true;
				rb.simulated = true;
				GameManager.instance.gameStart();
			}
		} else {
			if(Input.GetMouseButtonDown(0)) {
				rb.velocity = Vector2.zero;
				rb.AddForce(new Vector2(0, upForce));
			}
		}
	}

	void OnCollisionEnter2D (Collision2D col) {
		gameOver = true;
		GameManager.instance.gameOverMethod();
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "Pipe" && !gameOver) {
			gameOver = true;
			GameManager.instance.gameOverMethod();
		}

		if (col.gameObject.tag == "ScoreChecker" && !gameOver) {
			ScoreManager.instance.IncreamentScore();
		}
	}
}
