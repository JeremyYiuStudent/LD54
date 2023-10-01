using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusBarController : MonoBehaviour
{
    public GameObject shield1, shield2, health;

    // Update is called once per frame
    void Update()
    {
        shield1.transform.localScale = new Vector3((DataHolder.energy >= 100 ? DataHolder.energy-100:DataHolder.energy)/100f,1,1);
        shield2.transform.localScale = new Vector3(Math.Max(DataHolder.health-100, 0)/100f,1,1);
        health.transform.localScale = new Vector3(DataHolder.health/100f,1,1);
    }
}
