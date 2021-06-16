using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PrefabSpawner))]

public class SpawnerTimer : MonoBehaviour
{
	[SerializeField] float spawnInterval = 1f;
	PrefabSpawner spawner;

	float nextSpawnTime;

	private void Start()
	{
		spawner = GetComponent<PrefabSpawner>();
		nextSpawnTime = Time.time;
	}

	private void Update()
	{
		if (Time.time > nextSpawnTime)
		{
			nextSpawnTime += spawnInterval;
			spawner.SpawnObject();
		}
	}

}
