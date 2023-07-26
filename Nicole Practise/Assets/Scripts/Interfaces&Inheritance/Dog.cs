using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Mammal, IPet
{
    public Dog(string name)
    {
        Name = name;
    }

    public List<string> Tricks { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override void Mate()
    {
        Debug.Log("Dogs mating!");
        base.Mate();
    }

    public override void Move()
    {
        
    }

    protected override void HealthUp()
    {
        base.HealthUp();
    }

    public void TeachTrick()
    {
        
    }
}
