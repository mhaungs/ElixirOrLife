// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class dragonHealth : MonoBehaviour
// {
//     public int maxHealth = 100;
//     private int currentHealth;

//     void Start()
//     {
//         currentHealth = maxHealth;
//     }

//     public void TakeDamage(int damageAmount)
//     {
//         currentHealth -= damageAmount;
//         // if (currentHealth <= 0)
//         // {
//         //     // Dragon is defeated, perform necessary actions (e.g., destroy dragon)
//         //     Destroy(gameObject);
//         //     print("the dragon has died rough time to be a dragon");
//         // }
       
//         GameObject dragonObject = GameObject.FindGameObjectWithTag("DragonComplete");
//         // Get the Animator component from the dragon object
//         Animator dragonAnimator = dragonObject.GetComponent<Animator>();
//         if (currentHealth <= 0 && dragonAnimator != null)
//         {
//             // Trigger the specified state in the Animator
//             dragonAnimator.SetTrigger("Die");
//             print("the dragon has died rough time to be a dragon");
//         }
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonHealth : MonoBehaviour
{
    public ParticleSystem deathParticles; // Assign your particle system in the inspector
    public int maxHealth = 100;
    private int currentHealth;

    public GameObject potionPrefab;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damageAmount)
    {
        currentHealth -= damageAmount;
       
        print("hit");
        GameObject dragonObject = GameObject.FindGameObjectWithTag("DragonComplete");
        // Get the Animator component from the dragon object
        Animator dragonAnimator = dragonObject.GetComponent<Animator>();
        if (currentHealth <= 0 && dragonAnimator != null)
        {
            // Trigger the specified state in the Animator
            //dragonAnimator.SetTrigger("Die");
            print("the dragon has died rough time to be a dragon");

            Instantiate(deathParticles, transform.position, Quaternion.identity);

            // Optionally, play a sound effect
            // AudioManager.PlaySound("DeathSound");

            // Disable or remove the character GameObject
            dragonAnimator.enabled = false;
            dragonObject.SetActive(false);

            Instantiate(potionPrefab, transform.position, Quaternion.Euler(-90f, 0f, 0f));
        }
    }
}
