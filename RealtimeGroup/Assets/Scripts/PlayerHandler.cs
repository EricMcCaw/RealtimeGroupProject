﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public GameObject Playerprefab;
    GameObject Player1;
    GameObject Player2;
    // Start is called before the first frame update
    void Start()
    {
        Player1 = Instantiate(Playerprefab,transform.position + new Vector3(0,0,0), Quaternion.Euler(0, 90, 0));
        Player2 = Instantiate(Playerprefab,transform.position + new Vector3(2,0,0), Quaternion.Euler(0,90,0));

        Player2.GetComponent<Movement>().Playernum = 2;
        Player1.GetComponent<Movement>().Playernum = 1;

        SetPlayerNames();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetPlayerNames()
    {
        if (StaticClass.playerOneName == string.Empty)
        {
            StaticClass.SetPlayerOneName("Player 1");
        }


        if (StaticClass.playerTwoName == string.Empty)
        {
            StaticClass.SetPlayerTwoName("Player 2");
        }

        Player2.GetComponent<Movement>().name = StaticClass.playerTwoName;
        Player1.GetComponent<Movement>().name = StaticClass.playerOneName;


        Player2.GetComponent<Movement>().updateName();
        Player1.GetComponent<Movement>().updateName();

    }
}
