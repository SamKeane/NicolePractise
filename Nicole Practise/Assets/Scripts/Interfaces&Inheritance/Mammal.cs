using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mammal
{
    public string Name { get; protected set; }

    public float Health { get; private set; }

    public void Eat()
    {
        HealthUp();
    }

    public virtual void Mate()
    {
        // does something
    }

    public abstract void Move();

    protected virtual void HealthUp()
    {
        Health++;
    }
}
