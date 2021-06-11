using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BehaviorToggle : MonoBehaviour
{

	[SerializeField] MonoBehaviour behaviorToToggle;

	private void OnTriggerEnter(Collider other)
	{
		bool isActive = behaviorToToggle.enabled;

		if (isActive)
		{
			behaviorToToggle.enabled = false;
		}
		else
		{
			behaviorToToggle.enabled = true;
		}
	}

}
