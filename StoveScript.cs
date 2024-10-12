using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveScript : MonoBehaviour
{

    public FryingPanScript fp;
    public PlayerDetectorScript ds;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(ds.player != null){
            if(Input.GetKeyDown(KeyCode.R)){
                if(fp.isOccupied == false){
                    fp.setFood(ds.pc.getPickUp());
                }else{
                    ds.pc.pickUpFood(fp.getFood());
                    Debug.Log("take out food");
                }

                
            }
        }
    }
    
}
