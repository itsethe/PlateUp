using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum foodState{
    Raw,
    Done,
    Burnt
}

public class foodScript : MonoBehaviour
{
    public bool isCooking = false;
    public float cookingTime = 10;
    public float timer = 0;
    public foodState currentState;
    public string name;
    public string type;

    // Start is called before the first frame update
    void Start()
    {
        currentState = foodState.Raw;
    }

    // Update is called once per frame
    void Update()
    {
        if(isCooking == true){
            timer += Time.deltaTime;
        }

        if(timer > cookingTime+5){
            Debug.Log("burnt");
            currentState = foodState.Burnt;
            
        }else if(timer > cookingTime){
            Debug.Log("done cooking");
            currentState = foodState.Done;
        }
    }
}
