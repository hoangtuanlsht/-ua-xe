using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rb2d;

    public Vector3 moveinput;
    public float moveSpeed = 5f;

    private void Awake()
    {
        this.rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        moveinput.x = Input.GetAxis("Horizontal");
        moveinput.y = Input.GetAxis("Vertical");
        transform.position += moveSpeed * moveinput * Time.fixedDeltaTime;
    }

   

    
}
