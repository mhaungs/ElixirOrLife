using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_increase : MonoBehaviour
{
    public static int upgradehealth = 0;
    void Awake()
    {
        upgradehealth += 10;
    }
}
