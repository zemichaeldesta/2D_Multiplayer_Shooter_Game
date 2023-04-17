using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //bullet speed can easily be changed from unity editor. 

    public float speed;
    private Rigidbody2D rb;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            DestroyObject(gameObject);
        }

    }



        void Start()//this makes the bulet prefab move
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = transform.right * speed;
        
    }
   

   
}
