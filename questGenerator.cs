using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class questGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    public Text directions;
    List<string> order; 
    string[] ingredients;

    void Start()
    {
        order = new List<string>();
        ingredients = new string[] {"carrot", "apple", "banana", "beet", "cabbage", "egg", "ham", "turkey", "salad", "skewer"};

       generateQuest();
       

    }
    void generateQuest(){
         int random = Random.Range(1, 3);
        string directionsText = "";

        for(int i = 0; i < random; i++){
            order.Add(ingredients[Random.Range(0,10)]);

            directionsText += order[i] + "\n";

        }

        directions.text = directionsText;

        
    }

    void OnTriggerEnter(Collider c){
        
        if(c.CompareTag("Plate")){
            plateScript ps = c.gameObject.GetComponent<plateScript>();
            int count = 0;
            for(int i = 0; i < ps.foodList.Count; i++){
                if(order.Contains(ps.foodList[i])){
                    count += 1;
                }
            }
            
            if(count == order.Count && order.Count == ps.foodList.Count && ps.raw == false){
                directions.text = "complete";
                Destroy(c.gameObject);
                generateQuest();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
