﻿using UnityEngine;

public class EnemyMoveForward : MonoBehaviour
{

    private float acceleration = 75f;
    private float initialVelocity = 2f;

    private Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = Vector2.down * initialVelocity;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 ForceToAdd = Vector2.down * acceleration * Time.deltaTime;

        rb.AddForce(ForceToAdd);
    }
}