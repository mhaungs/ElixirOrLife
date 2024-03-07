using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firegone : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Flame")
        {
            Destroy(other.gameObject);
        }
    }
}
