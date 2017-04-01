using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkController : MonoBehaviour {

    private string _gameVersion = "0.1";
    public GameObject playerPrefab;

	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings(_gameVersion);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    void OnJoinedLobby()
    {
        Debug.Log("Tentative de connexion à une room aléatoire");
        PhotonNetwork.JoinRandomRoom();
    }

    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("Can't join random room! So create them");
        PhotonNetwork.CreateRoom(null);
    }

    void OnJoinedRoom()
    {
        Debug.Log("Connexion à une room établi");
        PhotonNetwork.Instantiate("Prefabs/" + playerPrefab.name, playerPrefab.transform.position, Quaternion.identity, 0);
    }
}
