using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour {

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





	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		run = false;
		view = GetComponent<PhotonView> ();
		aim = false;
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
		}
}


















