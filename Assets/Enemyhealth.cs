using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class enemyhealth : MonoBehaviour
{
    public Slider playerSlider3D;
    public int health1;
    public GameObject enemy;

    void Start()
    {
        playerSlider3D.maxValue = health1;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject != null)
        {
            playerSlider3D.value = health1;
        }
        if (health1 < 1)
        {

            enemy.GetComponent<EnemyDamaged>().ded();
        }
    }

    public void damage()
    {
        if (gameObject != null)
        {
            health1 -= 10;
        }
    }
}



