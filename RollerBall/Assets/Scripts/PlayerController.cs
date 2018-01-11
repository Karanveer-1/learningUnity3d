using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

	public float speed;
	public Text winText;
	public Text countText;
	private Rigidbody rb;
	private int count;

	void Start() {
		count = 0;
		rb = GetComponent<Rigidbody> ();
		countText.text = "Count" + count.ToString ();
		winText.text = "";
	}

	void FixedUpdate() {
    
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);


		rb.AddForce (movement * speed);
    }

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Pickup")) {
			other.gameObject.SetActive (false);
			count += 1;
			countText.text = "Count" + count.ToString ();
		}

		if (count >= 13) {
			winText.text = "You Win..!!";
		}
			
	} 


}

	