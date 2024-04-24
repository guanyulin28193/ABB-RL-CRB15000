using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerController : MonoBehaviour
{
    public float targetValue = 0;

    float currentTarget = 0;
    public bool pick;
    private ArticulationBody ab;

    void Start()
    {
        ab = GetComponent<ArticulationBody>();
    }

    void FixedUpdate()
    {
        if (pick)
        {
            OperateFinger();
        }
        else
        {
            ab.SetDriveTarget(ArticulationDriveAxis.Z, 0);
        }
    }


    private void OperateFinger()
    {
        if (currentTarget < targetValue)
        {
            currentTarget += 0.00004f;
            ab.SetDriveTarget(ArticulationDriveAxis.Z, currentTarget);
        }
    }
}