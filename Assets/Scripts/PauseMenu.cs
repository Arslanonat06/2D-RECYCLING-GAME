using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PausePanel;
    public GameObject PlayerPanel;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Resume()
    {
        PausePanel.SetActive(false);
        PlayerPanel.SetActive(true);
        Time.timeScale = 1;
    }

    public void Pause()
    {
        PausePanel.SetActive(true);
        PlayerPanel.SetActive(false);
        Time.timeScale = 0;
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }

    public void OnApplicationQuit()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
