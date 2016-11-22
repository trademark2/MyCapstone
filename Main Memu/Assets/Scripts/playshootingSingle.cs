using UnityEngine;
using System.Collections;
using System;

public class playshootingSingle : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform angleTransform;

	public float fireDelay = 0.25f;
	float cooldownTimer = 0;

	void Update () {

		Vector3 mousePosScreen = Input.mousePosition;
		Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePosScreen);
		Vector2 playerToMouse = new Vector2(mousePosWorld.x - transform.position.x,
			mousePosWorld.y - transform.position.y);
		playerToMouse.Normalize();

		float angle = Mathf.Asin(playerToMouse.y) * Mathf.Rad2Deg;

		cooldownTimer -= Time.deltaTime;

		if (playerToMouse.x < 0f)
			angle = 180 - angle;

		if (playerToMouse.x < 0f && transform.localScale.x > 0f)
		{
			transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 0f);
		}
		else if (playerToMouse.x > 0f && transform.localScale.x < 0f)
		{
			transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, 0f);
		}

		if (Input.GetButton("Fire1") && cooldownTimer <= 0)
		{

			Debug.Log("Angle: " + angle);

			cooldownTimer = fireDelay;
			Vector3 offset = transform.rotation * new Vector3(2f, .25f, 0);

			Instantiate(bulletPrefab, transform.position + offset, transform.rotation);
		}
	}
}
