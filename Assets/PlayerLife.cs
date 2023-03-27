using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;

public class PlayerLife : MonoBehaviour
{
    
    private Animator anim;
    private Rigidbody2D rb;
    public int cherries;
    
    [SerializeField] private TMP_Text cherriesText;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        
        if (collision.gameObject.CompareTag("Trap")&&cherries<3) // this checks if the item is a trap or not
        {
            Die();
            cherriesText.text = "Life: " + cherries / 3;

            //if the item is  a trap and the player has less than 3 cherries it calls the method die
        }

        if (collision.gameObject.CompareTag("Trap") && cherries > 3) // this checks if the item is a trap or not
        {
            cherries -= 3;
            cherriesText.text = "Life: " + cherries / 3;
            //if the item is  a trap and the player has less than 3 cherries it calls the method die
        }
    }
    private void Die()
    {
        rb.bodyType = RigidbodyType2D.Static;
        anim.SetTrigger("death");// this triggers the animation death
    }
    private void OnTriggerEnter2D(Collider2D collision)// I used this instead of on collision because previously set
                                                       // it to on trigger so the player dont bump into the collectable
    {
        if (collision.gameObject.CompareTag("Cherry"))//checking which item we are colliding with
        {

            Destroy(collision.gameObject); //destroys the cherry object after the player collides with the item
            cherries++; //adds to the player's number of cherries
            cherriesText.text = "Life: " + cherries / 3;

        }
        if (collision.gameObject.CompareTag("FinishLine")) // this checks if the item is a trap or not
        {
            Invoke("CompleteLevel", 1f);
            // CompleteLevel(); //if the item is  a trap it calls the method die
        }
    }
    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//reloads the level
    }
    private void CompleteLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
