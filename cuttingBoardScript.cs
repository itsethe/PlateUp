using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cuttingBoardScript : MonoBehaviour
{
    public Transform foodLocation;
    public GameObject food;
    public bool isOccupied = false;
    public Slider cookingBar;
    foodScript fs;
    public GameObject fire;
    // Start is called before the first frame update
    void Start()
    {
        cookingBar.gameObject.SetActive(false);
        fire.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(isOccupied == true && fs.type=="veggie"){
            cookingBar.value = fs.timer/fs.cookingTime;
            if(fs.currentState == foodState.Burnt){
                fire.SetActive(true);
            } 
       }
       
    }

    public void setFood(GameObject f){
        if(isOccupied == false){
            food = f;
            fs = food.GetComponent<foodScript>();
            fs.isCooking = true;
            isOccupied = true;
            cookingBar.gameObject.SetActive(true);
            food.transform.position = foodLocation.position;
            food.transform.rotation = transform.rotation;
            food.transform.SetParent(transform);
        }
        
    }
    public GameObject getFood(){
        if(isOccupied == true){
            fs.isCooking = false;
            cookingBar.gameObject.SetActive(false);
            fire.SetActive(false);
            isOccupied = false;
            return food;
        }else{
            return null;
        }
    }
}


