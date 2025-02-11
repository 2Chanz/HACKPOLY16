﻿using UnityEngine;
using System.Collections;

public class TankControls : MonoBehaviour {

    // Use this for initialization
    public float TankHP = 1;
    public float maxSpeed = 10;  //public variable for movement speed.
    public Transform tankGraphics;    //variable to represent the "graphics" child object in the editor.
    bool grounded = false;       //bool to check if the sprite is touching the ground.
    public Transform groundCheck;//variable to assign an empty object used for checking the ground. 
    public float fuel;
    public float jumpforce = 30;
    public GameObject bullet;
    public Transform firepoint;
    public LayerMask whatisGround; //Layer settings to adjust which objects in which layers are considered ground.
    void Start () {
        //tankGraphics = tankGraphics.transform.FindChild("Tank");
	}
	
	// Update is called once per frame
	void Update () {
        
        if ((fuel > 0) && Input.GetKey(KeyCode.W))
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpforce ));
            
            fuel--;
        }
        if (Input.GetMouseButtonDown(0))
        {
            FireBullet();
        }

    }

    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");// Variable used to store the movement double when moving horizontally.
        
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }

    void FireBullet()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }
    public void DamageTank()
    {
        TankHP -= 999999;
        if(TankHP <= 0)
        {

        }
        
    }
}
