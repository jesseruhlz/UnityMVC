using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthChangeLogger
{
    public HealthChangeLogger()
    {
        Player.OnHealthChange += LogNewHealth;
    }

    ~HealthChangeLogger()
    {
        Player.OnHealthChange -= LogNewHealth;
    }

    private void LogNewHealth(float health)
    {
        // log output to 1 decimal place
        string healthAsString = health.ToString("0.0");
        Debug.Log("health = " + healthAsString);
    }
}
