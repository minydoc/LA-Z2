using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbitController : MonoBehaviour {


	public float sensi_camera_Y = 2f;






	// Use this for initialization0
	void Start () {


	}
	
	// Update is called once per frame
	void LateUpdate () {

			float x = sensi_camera_Y * - Input.GetAxis ("Mouse Y");

			transform.Rotate (x, 0, 0);

	}
}
