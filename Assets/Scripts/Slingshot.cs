﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : MonoBehaviour
{

    [Header("Set in Inspector")]
    public GameObject prefabProjectile;

    [Header("Set Dynamically")]
    public GameObject launchPoint;
    public Vector3 launchPos;
    public GameObject projectile;
    public bool aimingMode;
    
    void Awake()
    {
        Transform launchPointTrans = transform.Find("LaunchPoint");
        launchPoint = launchPointTrans.gameObject;
        launchPoint.SetActive(false);
        launchPos = launchPointTrans.position;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnMouseEnter()
    {
        launchPoint.SetActive(true);
        //print("Slingshot:OnMouseEnter()");
    }

    void OnMouseExit()
    {
        launchPoint.SetActive(false);
        //print("Slingshot:OnMouseExit()");
    }

    void OnMouseDown()
    {
        aimingMode = true;
        projectile = Instantiate(prefabProjectile) as GameObject;
        projectile.transform.position = launchPos;
        projectile.GetComponent<Rigidbody>().isKinematic = true;
    }
}
