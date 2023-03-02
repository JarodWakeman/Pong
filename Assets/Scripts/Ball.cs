using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody2d;

    public float speed = 200.0f;

    private void Awake()
    {
        _rigidbody2d = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        ResetPosition();
        AddStartingForce();
    }

    public void ResetPosition()
    {
        _rigidbody2d.position = Vector3.zero;
        _rigidbody2d.velocity = Vector3.zero;

        
    }

    public void AddStartingForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) :
                                        Random.Range(0.5f, 1.0f);

        Vector2 direction = new Vector2(x, y);
        _rigidbody2d.AddForce(direction * this.speed);
    }

    public void AddForce(Vector2 force)
    {
        _rigidbody2d.AddForce(force);
    }

    
}
