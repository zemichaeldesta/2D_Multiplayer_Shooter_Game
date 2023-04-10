using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Cryptography;
using UnityEngine;

public class secondRightShooter : flip
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
    }

}


