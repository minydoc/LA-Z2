using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIMCamera : MonoBehaviour {

	public float aimZoom = 3;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (1)) {
			transform.Translate(0, 0, + aimZoom);

		}
		if (Input.GetMouseButtonUp (1)) {
			transform.Translate(0,0, - aimZoom);

		}
	}
}
