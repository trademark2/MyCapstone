using UnityEngine;
using System.Collections;

public class Playermanager : MonoBehaviour
{
    public float speedX;
    public float jumpSpeedY;

    bool facingRight, Jumping;
    float speed;

    Animator anim;
    Rigidbody2D rb;
	// Use this for initialization
	void Start ()
    {
		anim = GetComponent <Animator>() ;
		rb = GetComponent<Rigidbody2D>();
		//rb.transform.position = new Vector3(-10, 0, 0);
        facingRight = true;
	}
	
	// Update is called once per frame
	void Update ()
    {//player movement
        MovePlayer(speed);
        // Move left
        if(Input.GetKeyDown(KeyCode.A))
        {
            speed = -speedX;
            anim.SetInteger("State", 1);
        }
        if(Input.GetKeyUp(KeyCode. A))
        {
            speed = 0;
            anim.SetInteger("State", 0);
        }
        //Move Right
        if (Input.GetKeyDown(KeyCode.D))
        {
            speed = speedX;
            anim.SetInteger("State", 1);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            speed = 0;
            anim.SetInteger("State", 0);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce(new Vector2(rb.velocity.x, jumpSpeedY));
            anim.SetInteger("State", 2);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            speed = 0;
			anim.SetInteger("State",0);
        }
    }

    void MovePlayer(float playerSpeed)
    {
        rb.velocity = new Vector3(speed, rb.velocity.y, 0);
    }
}
