using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
	[SerializeField] GameObject prefab;
	[SerializeField] Transform spawnPoint;

	private void Update()
	{
		string fireButton = "Fire1";
		if (Input.GetButtonDown(fireButton))
		{
			SpawnObject();
		}
	}

	public void SpawnObject()
	{
		GameObject spawnedObject = Instantiate(prefab);
		spawnedObject.transform.position = spawnPoint.position;
		spawnedObject.transform.rotation = spawnPoint.rotation;
	}
}
