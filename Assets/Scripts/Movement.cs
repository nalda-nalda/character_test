using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float moveSpeed = 3.0f;
    private Vector3 moveDirection;

    Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
        moveSpeed = 5.0f;
        moveDirection = Vector3.right;
    }

    private void Update()
    {
        moveDirection = Vector3.zero;

        // if (Input.GetKey(KeyCode.UpArrow))
        // {
        //     moveDirection += Vector3.up;
        // }
        // else if (Input.GetKey(KeyCode.DownArrow))
        // {
        //     moveDirection += Vector3.down;
        // }
        // else if (Input.GetKey(KeyCode.LeftArrow))
        // {
        //     moveDirection += Vector3.left;
        // }
        // else if (Input.GetKey(KeyCode.RightArrow))
        // {
        //     moveDirection += Vector3.right;
        // }

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        if (x != 0 || y != 0)
        {
            animator.SetBool("1_Move", true);
            if (x == 1)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
            else if (x == -1)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
        }
        else
        {
            animator.SetBool("1_Move", false);
        }
        moveDirection = new Vector3(x, y, 0);
        // transform.position = transform.position + new Vector3(1, 0, 0) * 1;
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
        
    }
}
