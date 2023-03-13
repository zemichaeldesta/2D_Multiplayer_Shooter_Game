using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap")) // this checks if the item is a trap or not
        {
            Die(); //if the item is  a trap it calls the method die
        }
    }
    private void Die()
    {
        anim.SetTrigger("death");// this triggers the animation death
    }

}
