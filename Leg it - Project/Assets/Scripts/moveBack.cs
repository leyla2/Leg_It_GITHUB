﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBack : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(-1.5f * Time.deltaTime, 0,0);
	}
}
