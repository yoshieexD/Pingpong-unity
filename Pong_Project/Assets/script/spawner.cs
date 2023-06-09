using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class spawner : MonoBehaviour
{
    public GameObject paddle;
    public static bool player1exists = false;

    void Start()
    {
        if (player1exists == false)
        {
            Vector3 spawnPosition = new Vector3(-8, 0, 0);
            PhotonNetwork.Instantiate(paddle.name, spawnPosition, Quaternion.identity);
        }
        else
        {
            Vector3 spawnPosition = new Vector3(8, 0, 0);
            if (PhotonNetwork.LocalPlayer.ActorNumber == 2)
            {
                spawnPosition.x *= -1;
            }
            PhotonNetwork.Instantiate(paddle.name, spawnPosition, Quaternion.identity);
        }
        
    }
}