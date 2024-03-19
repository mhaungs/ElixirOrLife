using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged : MonoBehaviour
{
    public static bool imortal;
    public GameObject healthbar;
    public AudioSource explosion;
    public GameObject shield;

    public void Start()
    {
        imortal = false;
        shield.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemybullet")
        {
            if (ShooterController.shielded == false)
            {
                if (imortal == false)
                {
                    if (gameObject != null)
                    {
                        explosion.Play();
                        healthbar.GetComponent<Health>().damage();
                    }
                }
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Flame")
        {
            if (ShooterController.shielded == false)
            {
                if (imortal == false)
                {
                    healthbar.GetComponent<Health>().damage();
                }
            }
        }

    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {          
            imortal =! imortal;
        }
        shield.SetActive(imortal);
    }
}

