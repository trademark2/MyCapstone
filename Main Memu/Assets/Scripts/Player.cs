using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class Player : MonoBehaviour{

    float time;
    Text t;

    [SerializeField]
    private Stat health;

    void CheckTurnTime()
    {
    }


    void OnTriggerEnter2D()
    {
        Debug.Log("Entered 2D");
        health.CurrentVal -= 10;

        if (health.CurrentVal <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Destroy(this.gameObject);
    }

    private void Awake()
    {
        health.Initialize();
    }
	
	// Update is called once per frame
	void Update () {


	  /*  if (Input.GetKeyDown(KeyCode.Q))
        {
            health.CurrentVal -= 10;
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            health.CurrentVal += 10;
        }*/
    }

    void Start ()
    {


    }
}
