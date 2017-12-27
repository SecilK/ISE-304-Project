﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class Main : NetworkBehaviour {

    List<Gamer> Gamers;
    GameObject[] players;
    int turnCounter;
    Gamer currentPlayer;
	void Start () {
        turnCounter = 0;

        players = GameObject.FindGameObjectsWithTag("Player");
        Gamers[0] = new Gamer("Player1", players[0]);
        Gamers[1] = new Gamer("Player1", players[1]);
        Gamers[2] = new Gamer("Player1", players[2]);
        Gamers[3] = new Gamer("Player1", players[3]);
        currentPlayer = Gamers[turnCounter%4];
    }

    void Update () {
        ChangeTurn();
	}

    void ChangeTurn()
    {
        if (currentPlayer.done())
        {
            currentPlayer = Gamers[++turnCounter];
        }
    }
}