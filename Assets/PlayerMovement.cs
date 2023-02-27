//writen by Mattaniah Tsegaye and Zemichael Desta
//feb 26 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private float direction1=0f;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    private void Start()
    {
        //this code states the Rigidbody, sprite and animator so we can use it in our class
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    private void Update()
    {
        //this code makes the character move horizontaly
        //it moves the character in the y axis.
        //GetAxisRaw makes the character move horizontal and the character stops imediatly when you leave the button
        direction1 = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(direction1 * 7f, rb.velocity.y);


        //this code selectes space button to make the player jump.
        if (Input.GetButtonDown("Jump"))
        {
            //this code makes the character move up and down in the x axis.
            rb.velocity = new Vector2(rb.velocity.x, 10f);

        }

        UpdateAnimationUpdate();



    }
    private void UpdateAnimationUpdate()
    {
        if (direction1 > 0f) //this statement checks if the player is running or not
        {
            anim.SetBool("running", true); // means we are running
            sprite.flipX = false; //flips it to the opposite side
        }
        else if (direction1 < 0f)
        {
            anim.SetBool("running", true);//means we are running in the left direction
            sprite.flipX = true; //flips it to the opposite side
        }
        else //we are standing still
        {
            anim.SetBool("running", false);
        }
    }
}
