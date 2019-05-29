﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewRay : MonoBehaviour
{
    public float weaponRange = 50f;
    private Camera mainCamera;

    void Start()
    {

        mainCamera = GetComponentInParent<Camera>();
    }


    void Update()
    {

        Vector3 lineOrigin = mainCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));


        Debug.DrawRay(lineOrigin, mainCamera.transform.forward * weaponRange, Color.green);
    }
}

