using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D _rb;
    private Animator _animator;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        PlayerMove();
    }

    private void PlayerMove()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal, vertical);

        movement.Normalize();

        _rb.velocity = new Vector2(movement.x * moveSpeed, movement.y * moveSpeed);

        FlipCharacter(horizontal);

        if (Mathf.Abs(horizontal) > 0 || Mathf.Abs(vertical) > 0)
        {
            _animator.SetBool("IsWalking", true);
        }
        else
        {
            _animator.SetBool("IsWalking", false);
        }
    }

    void FlipCharacter(float horizontalInput)
    {
        if (horizontalInput < 0) // Moving left
        {
            transform.localScale = new Vector3(0.75f, 0.75f, 1);
        }
        else if (horizontalInput > 0) // Moving right
        {
            transform.localScale = new Vector3(-0.75f, 0.75f, 1);
        }
        // If horizontalInput is 0, you may want to keep the current facing direction.
    }
}
