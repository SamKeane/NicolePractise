using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hippo : Mammal
{
    public Hippo(string name)
    {
        Name = name;
    }

    public override void Move()
    {
        throw new System.NotImplementedException();
    }
}
