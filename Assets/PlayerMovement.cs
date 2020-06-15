using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    float x;
    float y;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        //Get imput
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");

       /*
        //transform.position += new Vector3(x, y, 0f) * speed * Time.deltaTime;
        //le transfiere velocidad al otro objeto vvvv
        //rb.velocity = new Vector2(x,y)*speed;

        //rb.MovePosition(transform.position + new Vector3(x, y, 0f) * speed * Time.deltaTime);*/
    }

    private void FixedUpdate() 
    {
        //calculate movement
        //Debug.Log("Time.fixedDeltaTime: " + Time.fixedDeltaTime);
        rb.MovePosition(transform.position + new Vector3( x, y, 0f) * speed * Time.deltaTime);

    }
}
