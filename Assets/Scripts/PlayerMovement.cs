//writen by Mattaniah Tsegaye and Zemichael Desta
//feb 26 2023
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb; 
    private BoxCollider2D coll;
    private Animator anim;
    private SpriteRenderer sprite;

    [SerializeField] private LayerMask jumpableGround;

    private float direction1 = 0f;
    [SerializeField]private float moveSpeed = 7f; //so we can easily change the value
    [SerializeField] private float jumpForce = 14f;

    private enum MovementState { idle,running,jumping,falling } //one data type for different mutually exclusive events
    
    // Start is called before the first frame update
    private void Start()
    {
        //this code states the Rigidbody, sprite and animator so we can use it in our class
        rb = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
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
        rb.velocity = new Vector2(direction1 * moveSpeed, rb.velocity.y);


        //this code selectes space button to make the player jump.
        if (Input.GetButtonDown("Jump")&&IsGrounded())
        {
            //this code makes the character move up and down in the x axis.
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);

        }

        UpdateAnimationState();



    }
    private void UpdateAnimationState ()
    {
        MovementState state;
        if (direction1 > 0f) 
        {
            state = MovementState.running;
            sprite.flipX = false; //flips it to the opposite side
        }
        else if (direction1 < 0f)
        {
            state = MovementState.running;
            sprite.flipX = true; //flips it to the opposite side
        }
        else //we are standing still
        {
            state = MovementState.idle;
        }
        if (rb.velocity.y> .1f) //means the y velocity is not zero so the player object is jumping
        {
            state = MovementState.jumping;
        }
        else if (rb.velocity.y < -.1f)
        {
            state = MovementState.falling;
        }
        anim.SetInteger("state", (int)state);
    }
    private bool IsGrounded()
    {
        return  Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }
}
