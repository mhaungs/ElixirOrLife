using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1_dmg : MonoBehaviour
{
    public GameObject healthbar;
    float timer = 0.0f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (ShooterController.shielded == false)
            {
                if (gameObject != null)
                {
                    healthbar.GetComponent<Health_lvl1>().damage();
                }
            }
        }

    }
    public void dmg()
    {
        healthbar.GetComponent<Health_lvl1>().damage();
        timer = 0;
    }

    public void Update()
    {
        timer += Time.deltaTime;
    }
    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
            if (ShooterController.shielded == false)
            {
                if (gameObject != null)
                {
                    if (timer > 1f)
                    {
                        dmg();
                   
                    }
                }
            }
        }
    }
    
}
