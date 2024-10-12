using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodSpawner : MonoBehaviour
{
    public GameObject food;
    public PlayerDetectorScript ds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && ds.player != null){
            if(ds.pc.pickUp == null){
                GameObject foods = Instantiate(food, transform.position, transform.rotation);
                ds.pc.pickUpFood(foods);
            }
           
        }
    }
}
