using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreater : MonoBehaviour {

	public bool gameOver;
	public GameObject platform;
	Vector3 lastPos;
	float size;

	// Use this for initialization
	void Start () {
		lastPos = platform.transform.position;
		size = platform.transform.localScale.x;

		for (int i = 0; i < 20; i++) {
			random();
		}
		InvokeRepeating("random", 2f, 0.2f);

	}
	
	// Update is called once per frame
	void Update () {
		if (gameOver) {
			CancelInvoke("random");
		}
	}

	void random () {
		
		int random = Random.Range (0, 6);
		if (random < 3) {
			CreateX ();
		} else {
			CreateZ();
		}
	}

	void CreateX () {
		Vector3 tempPos = lastPos;
		tempPos.x += size;
		lastPos = tempPos;
		Instantiate(platform, tempPos, Quaternion.identity);
	}

	void CreateZ () {
		Vector3 tempPos = lastPos;
		tempPos.z += size;
		lastPos = tempPos;
		Instantiate(platform, tempPos, Quaternion.identity);
	}
}
