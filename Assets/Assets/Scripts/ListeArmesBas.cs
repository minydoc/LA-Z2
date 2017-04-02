using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListeArmesBas : MonoBehaviour {




	public int[] slot;
	public bool Arme;
	private Image Image;


	// Use this for initialization
	void Start () {
		slot = new int[6];
		GameObject ArmeOn = GameObject.FindGameObjectWithTag ("Player");
		MovePlayer MovePlayer = ArmeOn.GetComponent<MovePlayer> ();
		//Arme = MovePlayer.PistolActiv;




	}
	
	// Update is called once per frame
	void Update () {

		if (Arme == true){

		}
	}
}
