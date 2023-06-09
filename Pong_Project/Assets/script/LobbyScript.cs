using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
using UnityEngine.SceneManagement;

public class LobbyScript : MonoBehaviourPunCallbacks
{
    public TMP_InputField crtxt;
    public TMP_InputField jrtxt;

    void Start()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnJoinedRoom()
    {
        spawner.player1exists = true;
        PhotonNetwork.LoadLevel(2);
    }

    public void CreateRoom()
    {
            PhotonNetwork.CreateRoom(crtxt.text);
    }

    public void JoinRoom()
    {
            PhotonNetwork.JoinRoom(jrtxt.text);
            
    }
}
