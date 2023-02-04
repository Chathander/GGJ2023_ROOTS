using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PullGravity : MonoBehaviour
{
    public Rigidbody2D rb2D;

    public float gravForce;

    public float gravityDistence;

    public GameObject planet;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Vector3.Distance(planet.transform.position, transform.position);
    }
}
