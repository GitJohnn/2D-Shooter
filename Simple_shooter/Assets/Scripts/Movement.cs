using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D myrigidbody;
    private Vector2 moveVelocity;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void FixedUpdate()
    {
        myrigidbody.MovePosition(myrigidbody.position + moveVelocity * Time.deltaTime);
    }


    void GetInput()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

}
