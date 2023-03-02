using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player3Paddle : Paddle
{
    private Vector2 _direction;

    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _direction = Vector2.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _direction = Vector2.right;
        }
        else
        {
            _direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (_direction.sqrMagnitude != 0)
        {
            _rigidbody.AddForce(_direction * speed);
        }
    }
}
