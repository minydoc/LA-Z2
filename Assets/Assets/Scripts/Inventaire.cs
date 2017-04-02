using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventaire : MonoBehaviour {

	bool activation = false;


	// Use this for initialization
	void Start () {
		GetComponent<Canvas> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.I)) {
			activation = !activation;
			GetComponent<Canvas> ().enabled = activation;
		}


	}
}
