﻿using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Stat
{
    [SerializeField]
    private BarScript bar;  
    [SerializeField]
    private float maxVal;
    [SerializeField]
    private float currentVal;
    
    public float CurrentVal
    {
        get
        {
            return currentVal;
        }

        set
        {

            currentVal = value;
            bar.Value = currentVal;
        }
        
                  
   }

    public float MaxVal
    {
        get
        {
            return maxVal;
        }

        set
        {
            maxVal = value;
            bar.MaxValue = maxVal;
        }
    }

    public void Initialize()
    {
        this.MaxVal = maxVal;
        this.CurrentVal = currentVal;
    }
}