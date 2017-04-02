using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachementGunMainDroite : MonoBehaviour {


	private GameObject target;








	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (target == null) {
			//On récupère le gameobject avec le tag Camera position
			target = GameObject.FindGameObjectWithTag ("Rhand");



		} 
	}

	void LateUpdate (){
		if (target != null) {

			//On récupère la position à donner à l'objet (celle du gameobject Target)
			float x = target.transform.position.x;
			float y = target.transform.position.y;
			float z = target.transform.position.z;

	


			//On place l'objet
			transform.position = new Vector3 (x, y, z);

			//transform.Rotate (xr, yr, zr);


		}




	}

}
