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
        float dist = Vector3.Distance(planet.transform.position, transform.position);
        Vector3 vecK = planet.transform.position - transform.position;
        rb2D.AddForce(vecK.normalized * ((1.0f - dist / gravityDistence) * gravForce));
    }
}
