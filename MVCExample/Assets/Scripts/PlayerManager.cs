using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private PlayerController playerController;
    private HealthChangeLogger healthChangeLogger;

    private void Start()
    {
        playerController = new PlayerController();
        healthChangeLogger = new HealthChangeLogger();
    }

    private void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            playerController.AddToHealth();
        }
        if (Input.GetKeyDown("down"))
        {
            playerController.ReduceHealth();
        }
    }
}
