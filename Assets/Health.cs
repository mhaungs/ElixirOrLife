using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{

    public Slider playerSlider3D;
    public int health;
    public GameObject player;
    public GameObject GameOver;
  
    void Start()
    {
        Time.timeScale = 1;
        playerSlider3D.maxValue = health;
        GameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        playerSlider3D.value = health;

        if (health <= 1)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
        if (player.transform.position.y <= 60)
        {
            death();
        }
    }

    public void damage()
    {
        health -= 10;

    }

    public void death()
    {
        health -= 1000;

    }
}



