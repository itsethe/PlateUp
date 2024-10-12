using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateDetector : MonoBehaviour
{
    public bool hasPlate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerExit(Collider c){
        if(c.CompareTag("Plate")){
            hasPlate = false;
        }
    }
    void OnTriggerEnter(Collider c){
        if(c.CompareTag("Plate")){
            hasPlate = true;
        }
    }
}
