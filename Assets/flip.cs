using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flip : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Y))
        {
            flipper();
        }

        if (Input.GetKey(KeyCode.U))
        {
            flipper();
        }
    }
    private void flipper() 
    {
        Vector3 localScale = transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }
}
