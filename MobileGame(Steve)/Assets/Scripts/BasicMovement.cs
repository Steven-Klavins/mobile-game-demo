using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{

    public float jHeight = 6;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            rb.gravityScale = 0;
            rb.transform.Translate(Vector3.up * jHeight * Time.deltaTime);
        }
        else
        {
            rb.gravityScale = 1;
        }
    }
}
