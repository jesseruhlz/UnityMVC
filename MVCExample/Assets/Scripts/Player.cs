using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public delegate void HealthChangeAction(float health);
    public static event HealthChangeAction OnHealthChange;

    private float health;
    private const float MIN_HEALTH = 0;
    private const float MAX_HEALTH = 1;

    public Player(float health = 1)
    {
        this.health = health;
        //publish initial value
        PublishHealthChangeEvent();
    }

    public float GetHealth()
    {
        return health;
    }

    public void AddHealth(float amount)
    {
        this.health += amount;
        if(this.health > MAX_HEALTH)
        {
            this.health = MAX_HEALTH;
        }
        PublishHealthChangeEvent();
    }
    
    public void ReduceHealth(float amount)
    {
        this.health -= amount;
        if(this.health < MIN_HEALTH)
        {
            this.health = MIN_HEALTH;
        }
        PublishHealthChangeEvent();
    }

    private void PublishHealthChangeEvent()
    {
        if (null != OnHealthChange)
        {
            OnHealthChange(this.health);
        }
    }
}
