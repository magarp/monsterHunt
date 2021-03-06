﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneController : MonoBehaviour {

	public Transform target;
	public float movementSpeed = 9.0f;
	public AudioSource planeAudio;

	// Use this for initialization
	void Start () {
		planeAudio.Play ();

	}


	// Update is called once per frame
	void Update () {
		float step = movementSpeed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		if (transform.position == target.position) {
			Destroy (gameObject);
		}

	}


}
