﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCam : MonoBehaviour
{

    public Transform target;
    public float smoothTime = 0.4f;

    Vector3 thisVelocity = Vector3.zero;

    // Update is called once per frame
    void FixedUpdate() //use fixed update if following a physics based thing
    {
        Vector3 targetPosition = target.TransformPoint(new Vector3(0, 0.8f, -10f)); //defining target pos, slightly above and behind target transform.

        //smoothly move the cam towards the target pos (juice, smooth)
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref thisVelocity, smoothTime);

    }
}
