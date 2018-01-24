using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour {

	public GameObject pipe;
	public float maxY;
	public float spawnTime;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void stop () {
		CancelInvoke("create");
	}

	public void start () {
		InvokeRepeating("create", 0.2f, spawnTime);
	}

	void create () {
		Instantiate(pipe, new Vector3(transform.position.x, Random.Range(-maxY, maxY), 0), Quaternion.identity);
	}
}
