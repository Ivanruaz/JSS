using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSetup : MonoBehaviour
{
    public void changeScenes(int numberScenes)
    {
        SceneManager.LoadScene(numberScenes);
        Time.timeScale = 1.0f;

    }
    public void load_scen()
    {

        SceneManager.LoadScene("_scene");
    }
    public void load_menu()
    {

        SceneManager.LoadScene("menu");
    }
}