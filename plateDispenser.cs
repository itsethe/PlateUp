using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plateDispenser : MonoBehaviour
{
    public plateDetector pd;
    public GameObject spawnpoint;
    public GameObject plate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pd.hasPlate == false){
            Instantiate(plate, spawnpoint.transform.position, spawnpoint.transform.rotation);
        }
    }
}
