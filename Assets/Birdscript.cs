using Unity.Mathematics;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;

public class Birdscript : MonoBehaviour
{
    private Rigidbody2D BirdRB;
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        BirdRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            BirdRB.linearVelocity = Vector2.up * _velocity;
        }
    }
    private void FixedUpdate()
    {
        transform.rotation = quaternion.Euler(0, 0, BirdRB.linearVelocity.y * _rotationSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.instance.GameOver();
    }
}
