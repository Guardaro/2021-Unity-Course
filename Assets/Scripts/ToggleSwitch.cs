using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSwitch : MonoBehaviour
{
	[SerializeField] GameObject objectToToggle;

	private void OnTriggerEnter(Collider other)
	{
		bool isActive = objectToToggle.activeSelf;

		if (isActive)
		{
			objectToToggle.SetActive(false);
		}
		else
		{
			objectToToggle.SetActive(true);
		}
	}

}
