using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;
//written by Mattaniah Tsegaye
//this script is used for the moving platform 
public class WayPointFollower : MonoBehaviour
    //puts waypoint 1 &2 in an arry 
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;
    
    [SerializeField] private float speed = 2f;
 

    // Update is called once per frame
    private void Update()
    {
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            currentWaypointIndex++;
            if(currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);
    }
}
