﻿using UnityEngine;
using System.Collections;

public class FireBullet : MonoBehaviour {

    // Use this for initialization
    public int bulletspeeds;
    public float lifetime = 2.0f;
    public int damage = 40;
    Collider2D bulletcollider;
    Rigidbody2D bullet;
    void Awake()
    {
        bullet= GetComponent<Rigidbody2D>();
        bulletcollider = GetComponent<Collider2D>();
    }
    void Update()
    {
        if (true)
        {
            transform.position += Time.deltaTime * bulletspeeds * transform.right;
        }
        destroy();
    }
    
    void FixedUpdate()
    {
        
    }
    void Travel()
    {
        Vector2 mousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        Vector2 currentpos = this.transform.position;
        Vector2 Direction = mousePosition - currentpos;
        Direction.Normalize();
        bullet.velocity = Direction * bulletspeeds; 

    }
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D hitbox)
    {
        if (hitbox != null)
        {
            
            
        }
        
    }

    void destroy () {
        lifetime -= Time.deltaTime;
        if(lifetime <= 0)
        {
            Destroy(gameObject);
        }
	}
}
