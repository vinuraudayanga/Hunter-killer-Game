﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LossLife : MonoBehaviour
{

	public AudioSource hurtSound;

	private void OnTriggerEnter2D(Collider2D col)
	{
		LifeControlScript.health -= 1;
		hurtSound.Play();
	}
}
