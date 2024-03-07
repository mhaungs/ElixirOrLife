using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stay : MonoBehaviour
{
    public GameObject Player;
    public GameObject platform;
 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            Player.transform.parent = platform.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }
    }
}
