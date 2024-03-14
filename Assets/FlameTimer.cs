using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlameTimer : MonoBehaviour
{
    // Start is called before the first frame update
    float _flameLifetimeInSeconds = 5f;
    void Start()
    {
        Destroy(gameObject, _flameLifetimeInSeconds);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
