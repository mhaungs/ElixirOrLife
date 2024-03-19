using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamaged : MonoBehaviour
{
    public static bool endgame;
    public GameObject healthbar;

    public void Start()
    {
        endgame = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            if (gameObject != null)
            {
                healthbar.GetComponent<enemyhealth>().damage();
            }
        }
        if (collision.gameObject.tag == "Diamond")
        {
            if (gameObject != null)
            {
                healthbar.GetComponent<enemyhealth>().damage();
            }
        }
    }
    public void ded()
    {
        if(gameObject.tag == "Boss")
        {

            endgame = true;
        }
        else
        {
            Destroy(gameObject);
        }
     
    }
}

