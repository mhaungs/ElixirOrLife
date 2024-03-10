using UnityEngine;

public class SpawnOnCollision : MonoBehaviour
{
    // The prefab to spawn
    public GameObject objToEnable;

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with the box
        if (collision.gameObject.CompareTag("Player"))
        {
            // If the object is found, enable it
            if (objToEnable != null)
            {
                objToEnable.SetActive(true);
            }
            else
            {
                Debug.LogWarning("GameObject to enable not found.");
            }
        }
    }
}
