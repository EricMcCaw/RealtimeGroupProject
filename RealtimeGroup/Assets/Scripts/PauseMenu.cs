using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseMenu;
    private bool isPaused = false;


    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Pause"))
        {
            if (!isPaused)
            {
                Time.timeScale = 0;
                pauseMenu.SetActive(true);
                isPaused = !isPaused;
            }
            else
            {
                Time.timeScale = 1;
                pauseMenu.SetActive(false);
                isPaused = !isPaused;
            }
        }
    }

    public void Unpuase()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
        isPaused = !isPaused;
    }

}
