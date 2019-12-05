using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class CustomButon : MonoBehaviour
{
    public GameObject nameInput;
    private bool hover = false;

    private float oScaleX, oScaleY;

    private void Start()
    {
        oScaleX = transform.localScale.x;
        oScaleY = transform.localScale.y;
    }


    void Update()
    {
        if (hover)
        {
            if (transform.localScale.x <= oScaleX * 1.5)
            {
                double x = transform.localScale.x + transform.localScale.x * Time.deltaTime * 2;
                double y = transform.localScale.y + transform.localScale.y * Time.deltaTime * 2;
                transform.localScale = new Vector3((float)x, (float)y,1);
            }
        }
        else
        {

            if (transform.localScale.x >= oScaleX)
            {
                double x = transform.localScale.x - transform.localScale.x * Time.deltaTime;
                double y = transform.localScale.y - transform.localScale.y * Time.deltaTime;
                transform.localScale = new Vector3((float)x, (float)y, 1);
            }
        }
    }

    public void isMouseOver(bool b)
    {
        hover = b;
    }

    public void OpenNameInput()
    {
        nameInput.SetActive(true);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void SetPlayerOneName(string s)
    {
        StaticClass.SetPlayerOneName(s);
    }

    public void SetPlayerTwoName(string s)
    {
        StaticClass.SetPlayerTwoName(s);
    }
}
