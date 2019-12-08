using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal_Script : MonoBehaviour
{
    public float Timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Player")
        {
            collision.transform.position = collision.transform.GetComponent<Movement>().start;
            //SceneManager.LoadScene("Level2");
        }
    }
    public void setLevelTimer()
    {
        Timer = 500;
    }
    public void decreaseTimer(float deltaTime)
    {
        Timer -= deltaTime;
       
    }
}
