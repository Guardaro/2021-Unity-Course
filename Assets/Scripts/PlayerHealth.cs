using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	[SerializeField] int hitPoints = 10;

	private void Update()
	{
		if (Input.GetButton("Fire1"))
		{
			TakeDamage(1);
		}
	}

	public void TakeDamage(int damage)
	{
		hitPoints -= damage;
		if(hitPoints <= 0)
		{
			Die();
		}
	}

	private void Die()
	{
		Destroy(gameObject);
	}
}
