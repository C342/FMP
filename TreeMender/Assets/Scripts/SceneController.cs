using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Level 1");
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Options()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Options");
        }
    }

    public void Credits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Credits");
        }
    }

    public void ReturnToTitle()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }
    public void LoadShop()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("ShopScreen");
        }
    }
}