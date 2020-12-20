using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarControler : MonoBehaviour
{

    public float speed = 15;
    public float rotSpeed = 100;
    //adjust how far the car will rise upwards
    public float levitateSpeed = .001f;

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
            transform.Translate(0, levitateSpeed , 0);
        }
        
        //rotate car if flipped over
        if(Input.GetKeyDown("q"))
        {
            transform.Rotate(0, 0, r * rotSpeed * Time.deltaTime);
            GameManager.Log("rotating car");
        }
    }
}
