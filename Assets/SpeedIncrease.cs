using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedIncrease : MonoBehaviour
{
    // Start is called before the first frame update
    public static float upgradespeed = 0;
    void Awake()
    {
        upgradespeed += 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
