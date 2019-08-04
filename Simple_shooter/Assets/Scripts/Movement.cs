using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D myrigidbody;
    private Vector2 moveVelocity;
    public float speed;
    //GameManager is GM
    bool GM;

    // Start is called before the first frame update
    void Awake()
    {
        GM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().game;
        myrigidbody = GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update()
    {
        //Update the bool variable
        GM = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().game;
        if (GM)
        {
            GetInput();
        }
        else
        {
            speed = 0;
        }
    }

    void FixedUpdate()
    {
        if(GM)
        {
            myrigidbody.MovePosition(myrigidbody.position + moveVelocity * Time.deltaTime);
        }
        else
        {
            myrigidbody.MovePosition(Vector2.zero);
        }
    }


    void GetInput()
    {
        Vector2 moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveInput.normalized * speed;
    }

}
