using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehavior : MonoBehaviour
{
    private void Awake()
    {
        DistanceCalculator.OnSwitchTarget += ChangeTarget;
    }

    public void ChangeTarget()
    {
       
    }
    
}
