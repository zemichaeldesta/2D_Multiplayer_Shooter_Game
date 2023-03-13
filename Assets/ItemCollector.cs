using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using static System.Net.Mime.MediaTypeNames;

public class ItemCollector : MonoBehaviour
{
    public int cherries = 0; //counter variables
    [SerializeField] private TMP_Text cherriesText;
    private void OnTriggerEnter2D(Collider2D collision)// I used this instead of on collision because previously set
                                                       // it to on trigger so the player dont bump into the collectable
    {
        if (collision.gameObject.CompareTag("Cherry"))//checking which item we are colliding with
        {
            
            Destroy(collision.gameObject); //destroys the object after the player collides with the item
            cherries++;
            cherriesText.text="Cherries: "+ cherries;
        }
    }

}
