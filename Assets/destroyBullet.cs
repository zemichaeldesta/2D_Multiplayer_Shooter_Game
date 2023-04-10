using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class destroyBullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyThings(collision.gameObject);
    
    
    
    }
    public void DestroyThings(GameObject thing)
    {
        Destroy(thing);
    }
}