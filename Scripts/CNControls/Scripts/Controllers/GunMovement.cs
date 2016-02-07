using UnityEngine;
using System.Collections;
using CnControls;

//[RequireComponent(typeof(CharacterController))]
public class GunMovement : MonoBehaviour {

	//For JoyStick Control
	float rotateSpeed = 0.8f;


	//For Bullet fire
	public GameObject bullet, bulletEffect;
	public GameObject firePos; 
	

	public void FixedUpdate()
	{
		// Rotate around y - axis
		transform.Rotate(0, CnInputManager.GetAxis ("Horizontal") * rotateSpeed, 0);
		
	}
	
	void Update()
	{
		//Firing... woo

		if (SimpleJoystick.JRMove) {
			Invoke ("InstantiateBullet", 0f);
			Invoke ("InstantiateBulletEffect", 0f);
		}


	}


	void InstantiateBullet()
	{
		GameObject g1 = Instantiate (bullet, firePos.transform.position, firePos.transform.rotation) as GameObject;
		g1.transform.parent = firePos.transform;
	}

	void InstantiateBulletEffect()
	{
		GameObject g2= Instantiate(bulletEffect,firePos.transform.position,firePos.transform.rotation) as GameObject;
		g2.transform.parent = firePos.transform;
	}



}
