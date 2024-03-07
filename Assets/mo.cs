using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mo : MonoBehaviour
{
    float secondX;
    float secondy;
    float secondz;

    public float newX;
    public float newY;
    public float newZ;

    public float oldX;
    public float oldY;
    public float oldZ;

    void Start()
    {
        
    }

   void moving()
    {
        Vector3 firstPosition = new Vector3(oldX, oldY, oldZ);
        Vector3 secondPosition = new Vector3(newX, newY, newZ);
        while (transform.position.x < secondX)
        {
            transform.position = new Vector3(transform.position.x + 1f, transform.position.y, transform.position.z);
        }
    }
   

}
