using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetectorScript : MonoBehaviour
{
    public GameObject player;
    public PlayerController pc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider c){
        if(c.CompareTag("Player")){
            player = c.gameObject;
            pc = player.GetComponent<PlayerController>();

        }
    }
    void OnTriggerExit(Collider c){
        if(c.CompareTag("Player")){
            player = null;
            pc = null;
        }
    }
}
