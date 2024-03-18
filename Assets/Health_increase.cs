using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health_increase : MonoBehaviour
{
    //public static int upgradehealth = 0;
    public GameObject healthbar;

    void Awake()
    {
        healthbar.GetComponent<Health_lvl1>().increasehealth();
    }

   
}
