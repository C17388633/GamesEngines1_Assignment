using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarExtras : MonoBehaviour
{
    public float distance;
    public Transform goal;
    public float points = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        GameManager.Log("You have " + points + " points");


        // Get distance to Goal
        distance = Vector3.Distance( goal.transform.position, transform.position);
        GameManager.Log("Distance to Goal is: " + distance);


        GameManager.Log("Posistion x: " + goal.position.x + " position z: " + goal.position.z);
        GameManager.Log("Posistion of you x: " + transform.position.x + " position z: " + transform.position.z);

        //Say if Goal is in front of you or behind you
        /*
        Vector3 toPlayer = goal.position - transform.position  ;
        if (Vector3.Dot(transform.forward, toPlayer) < 0)
        {
            GameManager.Log("Goal is behind you");
        }
        else
        {
            GameManager.Log("Goal is in front of you");
        }

        //Get angle
        float angle = Mathf.Acos(Vector3.Dot(transform.forward, toPlayer) / toPlayer.magnitude) * Mathf.Rad2Deg;
        float a = Vector3.Angle(transform.forward, toPlayer);
        GameManager.Log("Angle to Goal: " + angle);
        GameManager.Log("Angle to Goal: " + a);*/

    }

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag == "Goal")
        {
            GameManager.Log("You have hit the goal!!!");
            points += 1;
        }
    }




}
