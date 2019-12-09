using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Script : MonoBehaviour
{
    public float Timer;
    // Start is called before the first frame update
    void Start()
    {
         
        setLevelTimer();
    }

    // Update is called once per frame
    void Update()
    {
        if (Timer <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            setLevelTimer();
        }
        else
        {
            decreaseTimer(Time.deltaTime);
        }
    }

    public void setLevelTimer()
    {
        Timer = 118;
    }
    public void decreaseTimer(float deltaTime)
    {
        Timer -= deltaTime;

    }
}
