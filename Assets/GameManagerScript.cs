using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public ThirdPersonController playerController;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void restart()
    {

        //playerController.ResetPlayer();
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //print("Check");

        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        // Destroy all the DontDestroyOnLoad game objects
        Destroy(XEntity.InventoryItemSystem.ItemManager.Instance.gameObject);
        Destroy(GameManager.instance.gameObject);
        Destroy(playerController.gameObject);

    }

}
