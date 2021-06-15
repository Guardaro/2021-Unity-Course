using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickyPlatform : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		Transform colliderTransform = other.transform;
		colliderTransform.parent = transform;
	}

	private void OnTriggerExit(Collider other)
	{
		Transform colliderTransform = other.transform;
		colliderTransform.parent = null;
	}


}
