using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateScript : MonoBehaviour
{
    public List<string> foodList = new List<string>();
    public bool raw = false;
     public PlayerDetectorScript ds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(ds.player != null){
        if(Input.GetKeyDown(KeyCode.R) && ds.pc.pickUp != null){
            GameObject food = ds.pc.getPickUp();
           food.transform.parent = this.transform;
            food.transform.position = this.transform.position + transform.up*0.1f;
            food.transform.rotation = this.transform.rotation;
            foodScript fs = food.GetComponent<foodScript>();
            foodList.Add(fs.name);
            if(fs.currentState != foodState.Done){
                raw = true;
            }
        }
            
        }
    }

    
}
