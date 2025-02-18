﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour {
	public Vector3 direction;
	public float speed = 10f;

	private float lifetime=2f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += direction * speed * Time.deltaTime;
		lifetime -= Time.deltaTime;
		if (lifetime <= 0f) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "enemy") {
			Destroy (collider.gameObject);
			Destroy (gameObject);
		}
	}
}
