﻿using UnityEngine;
using System.Collections;

public class DestroyOnTime : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Destroy(gameObject, 20f);
	}

}
