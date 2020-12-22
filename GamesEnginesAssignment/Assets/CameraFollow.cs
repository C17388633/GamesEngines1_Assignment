using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    //target being orb on top of car
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //travel to orb smoothly
        transform.position = Vector3.Lerp(transform.position, target.transform.position, Time.deltaTime);
        //look at orb
        transform.LookAt(target.parent);
    }
}
