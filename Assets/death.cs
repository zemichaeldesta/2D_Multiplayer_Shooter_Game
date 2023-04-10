using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class death : MonoBehaviour
{

    private Animator anim;
    private Rigidbody2D rb;
    

   private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.CompareTag("Bullet") ) // this checks if the item is a trap or not
        {
            Die();
            

            //if the item is  a trap and the player has less than 3 cherries it calls the method die
        }

       
    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");// this triggers the animation death
    }
    
    
    
}
