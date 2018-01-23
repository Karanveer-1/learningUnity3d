using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

	private Rigidbody2D rb;
	public float upForce;
	bool started;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!started) {
			if (Input.GetMouseButtonDown (0)) {
				started = true;
				rb.simulated = true;
			}
		} else {
			if(Input.GetMouseButtonDown(0)) {
				rb.velocity = Vector2.zero;
				rb.AddForce(new Vector2(0, upForce));
			}
		}
	}
}
