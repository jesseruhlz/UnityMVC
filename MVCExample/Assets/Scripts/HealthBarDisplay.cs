using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarDisplay : MonoBehaviour
{
    private Image healthMeterFiller;

    private void Awake()
    {
        healthMeterFiller = GetComponent<Image>();
    }

    private void OnEnable()
    {
        Player.OnHealthChange += UpdateHealthBar;
    }

    private void OnDisable()
    {
        Player.OnHealthChange -= UpdateHealthBar;
    }

    private void UpdateHealthBar(float health)
    {
        healthMeterFiller.fillAmount = health;
    }
}
