using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    Animator anim;
    Vector3 movement;
    Quaternion bodyRotation;
    bool isRunning;
    public float turnSpeed = 10;
    public float movementspeed=4;
    public GameObject rightHand;
    public GameObject pickUp;
    // Start is called before the first frame update
    void Start()
    {
        rb=GetComponent<Rigidbody>();
        anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float ws = Input.GetAxis("Vertical");
        float ad = Input.GetAxis("Horizontal");
        movement.Set(ad,0,ws);
        movement.Normalize();
        isRunning = !(Mathf.Approximately(ws,0) && Mathf.Approximately(ad,0));
        anim.SetBool("isRunning", isRunning);
        Vector3 desireForward = Vector3.RotateTowards(transform.forward, movement, turnSpeed*Time.deltaTime, 0);
        bodyRotation = Quaternion.LookRotation(desireForward);
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.F)){
            if(pickUp != null){
                Destroy(pickUp);
                pickUp = null;
            }
        }
    }
    void OnAnimatorMove(){
        rb.MovePosition(rb.position + movement * anim.deltaPosition.magnitude * movementspeed);
        rb.MoveRotation(bodyRotation);
    }
    void OnTriggerStay(Collider c){
        if(c.CompareTag("Food")){
            Debug.Log("touching food");
            if(Input.GetKeyDown(KeyCode.R) ){
                Debug.Log("touching R key");
                pickUpFood(c.gameObject);
            }
        }
        if(c.CompareTag("Plate")){
            Debug.Log("Touching plate");
            if(Input.GetKeyDown(KeyCode.E) ){
                
                pickUpFood(c.gameObject);
            }
        }
    }
    public GameObject getPickUp(){
        GameObject temp = pickUp;
        pickUp = null;
        return temp;
    }

    public void pickUpFood(GameObject f){
        if(pickUp == null){
            pickUp = f;
            pickUp.transform.position = rightHand.transform.position;
            pickUp.transform.rotation = pickUp.transform.rotation;
            pickUp.transform.SetParent(rightHand.transform);
        }
        
        
    }
}

