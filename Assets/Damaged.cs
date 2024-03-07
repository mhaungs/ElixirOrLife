using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged : MonoBehaviour
{

    float candmg;
    public GameObject healthbar;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemybullet")
        {
            if (gameObject != null)
            {
                healthbar.GetComponent<Health>().damage();
            }
        }
        if (collision.gameObject.tag == "Enemy")
        {
            if (gameObject != null)
            {
                healthbar.GetComponent<Health>().damage();
            }
        }
    }

    public void ded()
    {
        Destroy(gameObject);
    }
    public void dmg()
    {
        healthbar.GetComponent<Health>().damageSkel();
    }

    private void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Enemy")
        {
       
            if (gameObject != null)
            {
                Invoke("wait", 1f);
                dmg();
            }
        }
    }
    private void wait()
    {
    }
}

