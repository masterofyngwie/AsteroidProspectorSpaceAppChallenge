﻿using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {


	public float speed = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(Vector3.up * Time.deltaTime * speed);
	}
}
