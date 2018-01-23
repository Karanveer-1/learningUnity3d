using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeContoller : MonoBehaviour {

	public float speed;
	public float verticalSpeed;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		Move();
		InvokeRepeating("SwitchVerticalSpeed", 0.1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void SwitchVerticalSpeed() {
		verticalSpeed = -verticalSpeed;
		rb.velocity = new Vector2(-speed, verticalSpeed);
	}

	void Move () {
		rb.velocity= new Vector2(-speed, verticalSpeed);
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.gameObject.tag == "PipeRemover") {
			Destroy(gameObject);
		}
	}
}
