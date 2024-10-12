using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class preparationStation : MonoBehaviour
{

    public cuttingBoardScript cbs;
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
                if(cbs.isOccupied == false){
                    cbs.setFood(ds.pc.getPickUp());
                }else{
                    ds.pc.pickUpFood(cbs.getFood());
                    Debug.Log("take out food");
                }

                
            }
        }
    }
    
}
