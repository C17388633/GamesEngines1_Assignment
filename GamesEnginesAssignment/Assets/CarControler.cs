using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControler : MonoBehaviour
{

    public float speed = 5;
    public float rotSpeed1 = 100;
    public float rotSpeed2 = 150;
    //adjust how far the car will rise upwards
    public float levitateSpeed = 20f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float c = Input.GetAxis("Vertical");
        transform.Translate(0, 0, c * speed * Time.deltaTime);

        float r = Input.GetAxis("Horizontal");
        transform.Rotate(0, r * rotSpeed1 * Time.deltaTime, 0);

        //fly car
        if(Input.GetKey(KeyCode.Space))
        {
            //go upwards in terms of the worlds Y-axis
            transform.Translate (Vector3.up * Time.deltaTime * levitateSpeed, Space.World);
            GameManager.Log("Going up");
        }
        
        //flip over car if upside down
        if(Input.GetKey("q"))
        {
            //transform.Rotate(0, 0, r * rotSpeed * Time.deltaTime);
            transform.Rotate (new Vector3 (0, 0, rotSpeed2) * Time.deltaTime);
            GameManager.Log("Flipping car");
        }
    }
}
