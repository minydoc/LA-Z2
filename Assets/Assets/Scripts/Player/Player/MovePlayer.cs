using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour {

	#region Variables
	public float sensi_camera_X = 2.0f;
	public float speed = 2.0F;
	public float jumpSpeed = 8.0F;
	public float gravity = 20.0F;
	public Animator anim;

	private Vector3 moveDirection = Vector3.zero;
	private float InputH;
	private float InputV;
	private bool run;
	private bool aim;
	private PhotonView view;
	private GameObject Pistolet;
	private GameObject Ak47;

	//variabe bool pour savoir si on a une arme en main
	public bool mainpleine;

	//Variable pour type d'arme : pistoler : 1, fusil : 2, grenade : 3
	public int typeArme;

	#endregion



	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		run = false;
		view = GetComponent<PhotonView> ();
		aim = false;
		//au départ : pas d'arme dans les mains donc : 
		mainpleine = false;
		typeArme = 0;
		Pistolet = GameObject.FindGameObjectWithTag ("Pistolet");
		Pistolet.active = false;
		Ak47 = GameObject.FindGameObjectWithTag ("Ak47");
		Debug.Log ("trouvé");
		Ak47.active = false;
	}
	
	// Update is called once per frame
	void Update () {
		CharacterController controller = GetComponent<CharacterController> ();
		if (view.isMine) {
				if (controller.isGrounded) {
						InputH = Input.GetAxis ("Horizontal");
						InputV = Input.GetAxis ("Vertical");			
				}

				float y = sensi_camera_X * Input.GetAxis ("Mouse X");
				float x = transform.rotation.x;
				float z = transform.rotation.z;
				transform.Rotate (x, y, z);

				// appuyer sur shift pour courrir
				if ((Input.GetKey (KeyCode.LeftShift)) || (Input.GetKey (KeyCode.RightShift))) {
					run = true;
				} else {
					run = false;
				}
				
				// Clicker droit pour viser/Zoomer
				if (Input.GetMouseButtonDown (1)) {
					aim = true;
					anim.SetBool ("Aim", aim);
				}
				if (Input.GetMouseButtonUp (1)) {
					aim = false;
					anim.SetBool ("Aim", aim);
				}
			}


		anim.SetFloat ("InputH", InputH);
		anim.SetFloat ("InputV", InputV);
		anim.SetBool ("Run", run);




		if (Input.GetButtonDown("F")){

			GetObjInfo();

		}

		}

	private void GetObjInfo (){
				//rayon pour récuprer un objet
		Ray ray = new Ray (Camera.main.transform.position, Camera.main.transform.forward);

		RaycastHit hit;

		if (Physics.Raycast (ray, out hit, 10f)) {
			Debug.DrawLine (Camera.main.transform.position, hit.point, Color.red);
			Debug.Log ("Objet à ramasser puis a supprimer :" + hit.collider.name);

			if (hit.collider.name == "Pistol"){
			Destroy (hit.transform.gameObject);
				if (Pistolet.active == false) {
					Pistolet.active = true;
					Debug.Log ("Pistolet ramassé");
				}
			}

			if (hit.collider.name == "Ak-47"){
				Destroy (hit.transform.gameObject);
				if (Ak47.active == false) {
					Ak47.active = true;
					Debug.Log ("AK47 ramassé");
				}
			}
		}
			
	}

		private void GetTirInfo (){
				//rayon pour tirer
		Ray rayO = new Ray (Camera.main.transform.position, Camera.main.transform.forward);




		RaycastHit hitO;
		if (Physics.Raycast (rayO, out hitO, 1000f)) {
			Debug.DrawLine (Camera.main.transform.position, hitO.point, Color.blue);
			Debug.Log ("Cible :" + hitO.collider.name);

		}
	}
}



















