using UnityEngine;
using System.Collections;
using System;
//using TurnMachine;

public class PlayerShooting : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform angleTransform;
	//public TurnBasedCombatStateMachine turns;
	TurnClass realTurns;



	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

	void Awake()
	{
		GameObject Rob = GameObject.Find("Rob");
		GameObject Rob2 = GameObject.Find("Rob2");
		realTurns = new TurnClass(Rob, Rob2);
		Debug.Log("executed the start line of playershooting");
		realTurns.nextTurn();
	}



	void Update () {

		Vector3 mousePosScreen = Input.mousePosition;
		Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePosScreen);

		cooldownTimer -= Time.deltaTime;
        Debug.Log(mousePosWorld);


		if(Input.GetMouseButtonUp(1) && cooldownTimer <= 0)
		{
			//Player is x1 y1
			//Mouse is x2 y2
			//(y2-y1)/(x2-x1) = Slope of the line between Mouse and Player
			//Inverse Tangent of the Slope = Angle

			float angle = (float)Math.Atan((mousePosScreen.y - transform.position.y) / (mousePosScreen.x - transform.position.x));


			cooldownTimer = fireDelay;
			Vector3 offset = transform.rotation * new Vector3(2f, .25f, 0);

			Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
			//TurnBasedCombatStateMachine.playerTurn++;
			//turns.currentState = turns.currentState;
			realTurns.nextTurn();



		}
	}
}
