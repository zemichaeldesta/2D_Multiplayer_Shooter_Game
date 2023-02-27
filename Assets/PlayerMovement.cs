//writen by Mattaniah Tsegaye
//feb 26 2023
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        //this code states the Rigidbody
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    private void Update()
    {
        //this code makes the character move horizontaly
        //it moves the character in the y axis.
        //GetAxisRaw makes the character move horizontal and the character stops imediatly when you leave the button
        float direction1 = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(direction1 * 7f, rb.velocity.y);


        //this code selectes space button to make the player jump.
        if (Input.GetButtonDown("Jump"))
        {
            //this code makes the character move up and down in the x axis.
            rb.velocity = new Vector2(rb.velocity.x, 10f);

        }


    }
}
