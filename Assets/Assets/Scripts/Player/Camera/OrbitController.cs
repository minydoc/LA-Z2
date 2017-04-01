using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OrbitController : MonoBehaviour {

	private Vector3 offset;
	public float sensi_camera_Y = 2f;
	public float angle_camera_bas = 320;
	public float angle_camera_haut = 80;



	Text AngleX;


	// Use this for initialization0
	void Start () {
		offset = transform.position;
		//AngleX = GameObject.Find("AngleX").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void LateUpdate () {
			






			float x = sensi_camera_Y * - Input.GetAxis ("Mouse Y");


			transform.Rotate (x, 0, 0);





		




		//On fait apparaitre dans le GUI l'ange de la caméra
		/*float rotx = transform.rotation.x;
			
		AngleX.text = "x : "  + rotx;
		*/
	}
}
