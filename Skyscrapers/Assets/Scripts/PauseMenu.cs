using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
        pauseMenuUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit");
        FindObjectOfType<AudioManager>().Play("menuClick");
    }
}
