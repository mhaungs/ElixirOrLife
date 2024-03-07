using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletlifetime : MonoBehaviour
{
    [SerializeField] ParticleSystem hitPrefab;
    [SerializeField] GameObject flame;
    [SerializeField] GameObject flame1;
    float bulletLifetimeInSeconds = 3f;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void Awake()
    {
        Destroy(gameObject, bulletLifetimeInSeconds);
    }
    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Instantiate(hitPrefab, collision.GetContact(0).point, transform.rotation);
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Boss")
        {
        }
        if (collision.gameObject.tag == "Stop")
        {
            Instantiate(flame1, collision.GetContact(0).point, transform.rotation);
            Destroy(this.gameObject);
        }
        else
        {
            Instantiate(flame, collision.GetContact(0).point, transform.rotation);
        }
    }
}
