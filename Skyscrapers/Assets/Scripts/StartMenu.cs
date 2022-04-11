using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public GameObject levelsMenuUI;
    public GameObject optionsMenuUI;
    public GameObject startMenuUI;

    public void StartGame()
    {
        startMenuUI.SetActive(false);
        levelsMenuUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Options()
    {
        startMenuUI.SetActive(false);
        optionsMenuUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting Game...");
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void OpBack()
    {
        optionsMenuUI.SetActive(false);
        startMenuUI.SetActive(true);
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void lvlBack()
    {
        startMenuUI.SetActive(true);
        levelsMenuUI.SetActive(false);
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Buildings()
    {
        SceneManager.LoadScene("BuildingScene");
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Containers()
    {
        SceneManager.LoadScene("ContainerScene");
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Battery()
    {
        SceneManager.LoadScene("BatteryScene");
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

    public void Greek()
    {
        SceneManager.LoadScene("GreekScene");
        FindObjectOfType<AudioManager>().Play("menuClick");
    }

}
