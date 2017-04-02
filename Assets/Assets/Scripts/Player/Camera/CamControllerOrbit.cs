using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControllerOrbit : MonoBehaviour {

	private GameObject target;
	private GameObject targetP;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

		if (target == null) {
			//On récupère le gameobject avec le tag Camera position
			target = GameObject.FindGameObjectWithTag ("CameraPosition");
			// On récupère le point à viser (Orbit)
			targetP = GameObject.FindGameObjectWithTag ("OrbitCamera");


		} 

	}


	void LateUpdate (){
		if (target != null) {

			//On récupère la position à donner à la caméra (celle du gameobject Target)
			float x = target.transform.position.x;
			float y = target.transform.position.y;
			float z = target.transform.position.z;

			//On place la camera
			transform.position =  new Vector3(x, y, z);
			//on lui dit quoi regarder (l'orbit de jeu)
			transform.LookAt (targetP.transform);



		}


	}
}

