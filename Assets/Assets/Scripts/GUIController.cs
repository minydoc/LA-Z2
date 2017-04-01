using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUIController : MonoBehaviour {

    Text StatusText,MasterText;
	// Use this for initialization
	void Start () {
        StatusText = GameObject.Find("StatusText").GetComponent<Text>();
        MasterText = GameObject.Find("MasterText").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        StatusText.text = "Status : " + PhotonNetwork.connectionStateDetailed.ToString();
        MasterText.text = "isMaster : " + PhotonNetwork.isMasterClient;
    }
}
