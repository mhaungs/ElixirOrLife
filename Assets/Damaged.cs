using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaged : MonoBehaviour
{

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
    }
    public void ded()
    {
        Destroy(gameObject);
    }
}

