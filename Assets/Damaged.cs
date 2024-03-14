using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged : MonoBehaviour
{
  
    public GameObject healthbar;
    public AudioSource explosion;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemybullet")
        {
            if (ShooterController.shielded == false)
            {
                if (gameObject != null)
                {
                    explosion.Play();
                    healthbar.GetComponent<Health>().damage();
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
                healthbar.GetComponent<Health>().damage();
            }
        }

    }
}

