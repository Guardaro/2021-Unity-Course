using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{
	[SerializeField] int damage = 1;

	private void OnTriggerEnter(Collider other)
	{
		PlayerHealth health = other.GetComponent<PlayerHealth>();
		if(health != null)
		{
			health.TakeDamage(damage);
			Destroy(gameObject);
		}
	}
}
