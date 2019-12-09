using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverScript : MonoBehaviour
{
    public Text  player1NameText, player2NameText;
    private string player1Name, player2Name;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        player1Name = StaticClass.playerOneName + " : ";
        player2Name = StaticClass.playerTwoName + " : ";

        player1NameText.text = player1Name + StaticClass.playerOneScore.ToString();
        player2NameText.text = player2Name + StaticClass.playerTwoScore.ToString();
    }
}
