using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticClass
{
    public static string playerOneName = string.Empty, playerTwoName = string.Empty;
    public static int playerOneScore, playerTwoScore;
    public static void SetPlayerOneName(string s)
    {
        playerOneName = s;
    }

    public static void SetPlayerTwoName(string s)
    {
        playerTwoName = s;
    }

    public static void SetPlayerOneScore()
    {
        playerOneScore = 0;
    }

    public static void SetPlayerTwoScore()
    {
        playerTwoScore = 0;
    }





}
