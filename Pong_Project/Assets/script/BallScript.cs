using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BallScript : MonoBehaviour
{
    public float speed = 5;
    private Vector3 initialPosition;
    
    void Start()
    {
        initialPosition = transform.position;
        GetComponent<Rigidbody2D>().velocity = new Vector2(2, 2 * speed);
    }

    void Update()
    {
        if (!PhotonNetwork.IsMasterClient) return;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Trigger"))
        {
            ResetBallPosition();
        }
    }

    private void ResetBallPosition()
    {
        transform.position = initialPosition;
        GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        // Wait for a short duration before resuming movement
        StartCoroutine(ResumeBallMovement());
    }

    private IEnumerator ResumeBallMovement()
    {
        yield return new WaitForSeconds(1f); // Adjust the duration as needed
        GetComponent<Rigidbody2D>().velocity = new Vector2(2, 2 * speed);
    }
}
