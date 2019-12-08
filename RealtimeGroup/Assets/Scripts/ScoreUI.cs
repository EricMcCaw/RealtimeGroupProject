using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public Text timerText, player1NameText, player2NameText;
    private string player1Name, player2Name;
    private float timer = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        player1Name = StaticClass.playerOneName + " : ";
        player2Name = StaticClass.playerTwoName + " : ";

        timerText.text = "00:00";
    }

    // Update is called once per frame
    void Update()
    {
        GameObject holder = GameObject.FindGameObjectWithTag("Holder");
        timer = holder.GetComponent<Level1Script>().Timer;

        int min = Mathf.FloorToInt(timer / 60);
        int sec = Mathf.FloorToInt(timer % 60);
        timerText.text = min.ToString("00") + ":" + sec.ToString("00");

        player1NameText.text = player1Name + StaticClass.playerOneScore.ToString();
        player2NameText.text = player2Name + StaticClass.playerTwoScore.ToString();
    }

}
