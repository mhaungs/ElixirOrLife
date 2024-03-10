using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Reference to the prefab you want to detect collisions with
    public GameObject prefabToDetect;

    // Reference to the object you want to spawn
    public GameObject objectToSpawn;

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision detected with: " + collision.gameObject.name);
        if (collision.gameObject.CompareTag(prefabToDetect.tag))
        {
            Debug.Log("Prefab collision detected!");
            Instantiate(objectToSpawn, transform.position, Quaternion.identity);
        }
    }
}
