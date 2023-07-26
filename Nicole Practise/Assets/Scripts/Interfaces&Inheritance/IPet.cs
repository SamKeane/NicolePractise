using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPet
{
    public void TeachTrick();

    public List<string> Tricks{ get; set; }
}
