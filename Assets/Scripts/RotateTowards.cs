using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RotateTowards : MonoBehaviour
{
    public Transform target;

    void Update()
    {
        Vector3 relativePos = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(Vector3.forward, relativePos);
        transform.rotation = rotation;
    }
}
