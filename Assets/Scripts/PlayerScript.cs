using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed = 10;
    private Rigidbody2D rb;
    private float move = 0;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(rb.velocity.x, move * playerSpeed * Time.deltaTime);
    }
    
    public void Up()
    {
        move = +1000;
    }
    public void Down()
    {
        move = -1000;
    }
    public void Stop()
    {
        move = 0;
    }
}
