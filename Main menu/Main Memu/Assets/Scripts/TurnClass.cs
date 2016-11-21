﻿using System;
using UnityEngine;
using System.Collections;

public class TurnClass
{

    private static int playerTurn; //this is the number representing who's turn it is
    private static int numPlayers = 2; // this is the max number of players
    GameObject Rob, Rob2;
    
    //get a refrence to the object

     public TurnClass()
    {

    }

    public TurnClass(GameObject p1, GameObject p2)
    {
        Rob = p1;
        Rob2 = p2;
        initializeThis();
        
    }

    public void initializeThis()
    {
        /* Rob.GetComponent<PlayerShooting>().enabled = false;
        Rob.GetComponent<Playermanager>().enabled = false;
        Rob2.GetComponent<PlayerShooting>().enabled = false;
        Rob2.GetComponent<Playermanager>().enabled = false; */

        playerTurn = 3;

    }

    public void nextTurn() {

        playerTurn = playerTurn + 1;
        if (playerTurn > numPlayers)
            playerTurn = 1; //the number showing whos turn it is goes back to 1 if its above max players
        Debug.Log("Player turn is " + playerTurn);

                        Rob.GetComponent<PlayerShooting>().enabled = false;
                        Rob.GetComponent<Playermanager>().enabled = false;
                        Rob2.GetComponent<PlayerShooting>().enabled = false;
                        Rob2.GetComponent<Playermanager>().enabled = false;

                   


                    if (playerTurn == 1)
                    {
                        Rob.GetComponent<PlayerShooting>().enabled = true;
                        Rob.GetComponent<Playermanager>().enabled = true; 
                    }


        if (playerTurn == 2)
        {
           Rob2.GetComponent<PlayerShooting>().enabled = true;
           Rob2.GetComponent<Playermanager>().enabled = true;
           
        }
                    // move camera to next player
                    // move controls to next player
                    // start timer countdown

                    /*
                    activate variable for next player if {
                    action taken
                    timer runs out
                    player falls off map with less than 10 hp (action taken to teleport back otherwise)
                    }
                    */
	}
}
