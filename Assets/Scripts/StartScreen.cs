using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public void StartGame()
    {
        //SceneManager.LoadScene("Resources/RPGPP_LT/Scene/Level_1");
        SceneManager.LoadScene("_Scenes/Level_1");
    }

}
