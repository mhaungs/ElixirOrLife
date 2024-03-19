using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1_dmg : MonoBehaviour
{
    
    public GameObject healthbar;
    float timer = 0.0f;
    public static bool imortal;
    public GameObject shield;
    public void Start()
    {
        imortal = false;
        shield.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            if (ShooterController.shielded == false)
            {
                if (gameObject != null)
                {
                    if (imortal == false)
                    {
                        healthbar.GetComponent<Health_lvl1>().damage();
                    }
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
        if (Input.GetKeyDown(KeyCode.H))
        {
            imortal = !imortal;
        }
        shield.SetActive(imortal);
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
                        if (imortal == false)
                        {
                            dmg();
                        }
                    }
                }
            }
        }
    }
    
}
