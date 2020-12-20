using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControler : MonoBehaviour
{

    public float speed = 5;
    public float rotSpeed = 100;
    //adjust how far the car will rise upwards
    public float levitateSpeed = 100f;

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
        transform.Rotate(0, r * rotSpeed * Time.deltaTime, 0);

        //fly car
        if(Input.GetKey(KeyCode.Space))
        {
            //transform.Translate (new Vector3 (0, levitateSpeed, 0) * Time.deltaTime);
            GameManager.Log("Going up");
        }
        
        //flip over car if upside down
        if(Input.GetKey("q"))
        {
            //transform.Rotate(0, 0, r * rotSpeed * Time.deltaTime);
            transform.Rotate (new Vector3 (0, 0, rotSpeed) * Time.deltaTime);
            GameManager.Log("Flipping car");
        }
    }
}
