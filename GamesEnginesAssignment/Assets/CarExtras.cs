﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarExtras : MonoBehaviour
{
    public float distance;
    //Goal
    public Transform G;
    public float points = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        //make G = object with tag "Goal"
        G = GameObject.FindGameObjectWithTag("Goal").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Tell user how many points they have.
        GameManager.Log("You have " + points + " points");


        // Get distance to Goal
        distance = Vector3.Distance( G.position, transform.position);
        GameManager.Log("Distance to Goal is: " + distance);

        //Tell user positions of you and the Goal
        GameManager.Log("Goal Position : " + G.position.x + " " + G.position.z);
        GameManager.Log("Your Position : " + transform.position.x + " " + transform.position.z);

        //Say if Goal is in front of you or behind you
        Vector3 toPlayer = G.position - transform.position  ;
        if (Vector3.Dot(transform.forward, toPlayer) < 0)
        {
            GameManager.Log("Goal is behind you");
        }
        else
        {
            GameManager.Log("Goal is in front of you");
        }
        
        //Get angle
        
        float a = Vector3.Angle(transform.forward, toPlayer);
        GameManager.Log("Angle to Goal: " + a);

    }

    

    //When triggered
    void OnTriggerEnter(Collider c)
    {
        Debug.Log("Triggered with: " + c.gameObject.tag);
        //check if the tag is goal.
        if (c.gameObject.tag == "Goal")
        {
            //say that you have reached the goal
            GameManager.Log("You have hit the goal!!!");
            // and you gain points
            points += 1;
        }
    }

    void OnTriggerStay(Collider c)
    {
        Debug.Log("Stay with: " + c.gameObject.tag);
        
    }

    void OnTriggerExit(Collider c)
    {
        Debug.Log("No longer Triggered with: " + c.gameObject.tag);
    }

}
