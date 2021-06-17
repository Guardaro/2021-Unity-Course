using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
	[SerializeField] int hitPoints = 10;

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

	public int GetHealth()
	{
		return hitPoints;
	}
}
