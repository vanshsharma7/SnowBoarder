using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float LtorqueAmount = 1f;
    [SerializeField] float RtorqueAmount = -1f;
    [SerializeField] float boostSpeed=30f;
    [SerializeField] float baseSpeed=20f;
    bool canMove=true;

    Rigidbody2D rb2d;
    SurfaceEffector2D surfaceeffector2D;
    // Start is called before the first frame update
    void Start()
    {
        rb2d= GetComponent<Rigidbody2D>();
        surfaceeffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove){
            RotatePlayer();
            RespondToBoost();
        }
    }
    public void DisableControls(){
        canMove=false;
    }
    void RotatePlayer(){
        if(Input.GetKey(KeyCode.LeftArrow)){
            rb2d.AddTorque(LtorqueAmount);
        }
        if(Input.GetKey(KeyCode.RightArrow)){
            rb2d.AddTorque(RtorqueAmount);
        }
    }
    void RespondToBoost(){
        if(Input.GetKey(KeyCode.UpArrow)){
            surfaceeffector2D.speed=boostSpeed;
        }
        if(Input.GetKey(KeyCode.DownArrow)){
            surfaceeffector2D.speed=baseSpeed;
        }
    }
}
