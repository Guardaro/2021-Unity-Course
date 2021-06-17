using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]

public class HealthDisplay : MonoBehaviour
{
	[SerializeField] PlayerHealth health;
	TextMeshProUGUI textMesh;

	private void Start()
	{
		textMesh = GetComponent<TextMeshProUGUI>();		
	}

	private void Update()
	{
		int currentHealth = health.GetHealth();
		textMesh.text = currentHealth.ToString();
	}
}
