using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Next_lvl : MonoBehaviour
{

    public ThirdPersonController playerController;

    private void OnTriggerEnter(Collider other)
    {
        Next();
    }

    public void Next()
    {
       

        //playerController.ResetPlayer();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //print("Check");

        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Level_3");

        //Destroy all the DontDestroyOnLoad game objects
        Destroy(XEntity.InventoryItemSystem.ItemManager.Instance.gameObject);
        Destroy(GameManager.instance.gameObject);
        Destroy(playerController.gameObject);
    }



    

    
}
