using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public int loops = 20;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject goalPrefab;
    public int radius = 20;
    public float theta = 5;
    public int numPrefabs = 20;
    // Start is called before the first frame update
    void Start()
    {
        
        //Spawn goal
        GameObject goal = GameObject.Instantiate<GameObject>(goalPrefab);
        int Goalx = Random.Range(-100, 200);
        int Goalz = Random.Range(-150, 150);
        goal.transform.position = new Vector3(Goalx, 170, Goalz);
        goal.transform.parent = this.transform;



        for(int i = 1 ; i <= loops ; i ++)
        {
            //numPrefabs = (int)(2.0f * Mathf.PI * i * radius);
            
            //float theta = Mathf.PI * 2.0f / ((float)numPrefabs);
            
            for (int j = 0 ; j < numPrefabs ; j ++)
            {
                float angle  = j * theta; 
                float x = Mathf.Sin(angle) * radius * (i) * 1.1f;
                float z = Mathf.Cos(angle) * radius * (i) * 1.1f;
                
                int gNum = Random.Range(0,3);
                GameObject g;
                //switch for rng
                switch (gNum)
                {
                    //generate the skyscrraper if 1
                    case 1:
                        g = GameObject.Instantiate<GameObject>(prefab1);
                        g.transform.position = new Vector3(x, 300, z);
                        g.GetComponent<Renderer>().material.color =
                            Color.HSVToRGB(j / (float) numPrefabs, 1, 1);
                        g.transform.parent = this.transform;
                        break;
                    //generate the house if 2
                    case 2:
                        g = GameObject.Instantiate<GameObject>(prefab2);
                        g.transform.position = new Vector3(x, 300, z);
                        g.GetComponent<Renderer>().material.color =
                            Color.HSVToRGB(j / (float) numPrefabs, 1, 1);
                        g.transform.parent = this.transform;
                        break;
                    default:
                        break;
                }

            }
        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
        }
    }
}
