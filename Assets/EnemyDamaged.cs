using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamaged : MonoBehaviour
{
    public GameObject healthbar;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bullet")
        {
            if (gameObject != null)
            {
                healthbar.GetComponent<enemyhealth>().damage();
            }
        }

    }
    public void ded()
    {
        Destroy(gameObject);
    }
}

