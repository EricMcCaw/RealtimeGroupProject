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
            SceneManager.LoadScene("TestLevel2");
        }
        decreaseTimer(Time.deltaTime);
        print(Timer);
    }

    public void setLevelTimer()
    {
        Timer = 20;
    }
    public void decreaseTimer(float deltaTime)
    {
        Timer -= deltaTime;

    }
}
