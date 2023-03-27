using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
    }
}


