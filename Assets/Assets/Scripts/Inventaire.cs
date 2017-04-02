using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Inventaire : MonoBehaviour {

	bool activation = false;
	public GameObject Player;


	// Use this for initialization
	void Start () {
		GetComponent<Canvas> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.I)) {
			activation = !activation;
			GetComponent<Canvas> ().enabled = activation;

			if (!activation) {
				Player.GetComponent<MovePlayer> ().enabled = true;
			} else {
				Player.GetComponent<MovePlayer> ().enabled = false;
			}
		}


	}
}
