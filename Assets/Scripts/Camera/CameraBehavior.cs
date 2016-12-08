﻿using UnityEngine;
using System.Collections;

public class CameraBehavior : MonoBehaviour
{

    private Transform cameraPosition;
    private Transform targetPlayer;
    private Vector3 direction;

    // Use this for initialization
    void Start()
    {
        cameraPosition = GameObject.Find("CameraPosition").transform;
        targetPlayer = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, cameraPosition.position, 0.1f);
        direction = targetPlayer.transform.position - transform.position;
        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.1f);
    }
}
