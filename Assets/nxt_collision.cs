using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class nxt_collision : MonoBehaviour
{
    public GameObject button;


    public void Start()
    {
        button.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        button.SetActive(true);
        Time.timeScale = 0f;
    }





}
