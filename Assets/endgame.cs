using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    public GameObject winner;
    // Start is called before the first frame update
    void Start()
    {
        winner.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (EnemyDamaged.endgame == true)
        {
            winner.SetActive(true);
            Time.timeScale = 0;
            Destroy(gameObject);
        }
     
    }
}
