using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class DamageHandler : MonoBehaviour {

    public int health = 3;

	void Start () {
	}

    void OnTriggerEnter2D()
    {
        Debug.Log("Entered 2D");
        health--;

    }

	void Update () {
	if(health <= 0)
        {
            Die();
        }
	}

    void Die()
    {
        Destroy(gameObject);
    }
}
