using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]private Transform player;
    public Transform player2;
    public float speed;

    private Vector2 pos;
    private Vector2 vel;


    // Update is called once per frame
    private void Update()
    {
        pos = (player.position + player2.position) * 0.5f;
        transform.position = Vector2.SmoothDamp(transform.position, pos, ref vel,speed);
        transform.position = new Vector3(/*player*/transform.position.x,transform.position.y,-10/*, player.position.y, transform.position.z*/); // we make sure camera position 
       //the z direction is not 0 otherwise it won't be visible.

    }
}
