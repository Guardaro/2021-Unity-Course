using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour
{
	[SerializeField] float lifeSpan = 5f;

	float destroyObjectTime;

	private void Start()
	{
		destroyObjectTime = Time.time + lifeSpan;
	}

	private void Update()
	{
		if(Time.time > destroyObjectTime)
		{
			Destroy(gameObject);
		}
	}
}
