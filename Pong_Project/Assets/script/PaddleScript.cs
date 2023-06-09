using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PaddleScript : MonoBehaviour
{
    public float speed = 5;
    PhotonView pview;

    void Start()
{
    spawner.player1exists = true;
    pview = this.gameObject.GetComponent<PhotonView>();
}

void Update()
{
    if (pview.IsMine)
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
        }
    }
    
}
}