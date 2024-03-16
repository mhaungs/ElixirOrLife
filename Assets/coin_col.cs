using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_col : MonoBehaviour
{
    public GameObject GoldSound;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GoldSound.GetComponent<coin_sound>().playSound();
        }
    }
}