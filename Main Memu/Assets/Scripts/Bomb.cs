using UnityEngine;
using System.Collections;

public class Bomb : Projectile {
    //bomb type projectiles should follow natural laws of physics, bouncing off players and objects until the timer counts down and they explode

    float timeToExplode { get; set; }

    void Explode()
    {
        //the object should explode in a flash animation, and shrapnel type objects should come forth
        //players standing nearby should be knocked back.
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	//update timetoexplode with timer


	}
}
