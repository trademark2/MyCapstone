using UnityEngine;
using System.Collections;
/* THIS IS NOT USED NOW

namespace TurnMachine
{
    public class TurnBasedCombatStateMachine
    {
        GameObject Wizard = GameObject.Find("Wizard");
        GameObject Wizard2 = GameObject.Find("Wizard2");
        int numPlayers = 2;
        public int playerTurn = 1;


        public enum BattleStates
        {
            START,
            PLAYERTURN,
            NEXTPLAYER,
            LOSE,
            WIN,
            TRANSITION,

        }

        public BattleStates currentState;
        

        // Use this for initialization
        public void Start()
        {
            currentState = BattleStates.START;
        }
        
        public void Nextplayer()
        {
            currentState = BattleStates.TRANSITION;
            currentState = BattleStates.START;
        }

        void Update()
        {
            switch (currentState)
            {
                case (BattleStates.START):
                    // set up game
                    break;
                case (BattleStates.NEXTPLAYER):
                    playerTurn = playerTurn + 1;
                    if (playerTurn > numPlayers)
                        playerTurn = 1;

                    while (playerTurn != 1)
                    {
                        Wizard.GetComponent<PlayerShooting>().enabled = false;
                        Wizard.GetComponent<PlayerMovement>().enabled = false;
                        Debug.Log("playerturn != 1");
                    }

                    while (playerTurn != 2)
                    {
                        Wizard2.GetComponent<PlayerShooting>().enabled = false;
                        Wizard2.GetComponent<PlayerMovement>().enabled = false;
                        Debug.Log("playerturn != 2");
                    }


                    while (playerTurn == 1)
                    {
                        Wizard.GetComponent<PlayerShooting>().enabled = true;
                        Wizard.GetComponent<PlayerMovement>().enabled = true;
                        Debug.Log("playerturn == 1");
                    }
                    

                    while (playerTurn == 2)
                        Wizard2.GetComponent<PlayerShooting>().enabled = true;
                        Wizard.GetComponent<PlayerShooting>().enabled = true;
                    //Wizard.GetComponent<PlayerShooting>.enabled = true //this is the script we need to use
                    //Wizard.GetComponent<PlayerMovement>.enabled = true
                    Debug.Log("playerturn == 2");

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
  /*                  break;
                case (BattleStates.LOSE):
                    // make person dissappear
                    break;
                case (BattleStates.WIN):
                    // show victory screen
                    break;

                case (BattleStates.TRANSITION):
                    //this is largely just to reset nextplayer, maybe a regular method would be better
                    break;


                    ///
            }

        }

    }
}


*/