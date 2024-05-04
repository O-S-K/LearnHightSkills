using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : IShield
{ 
    public void Defend()
    {
        Debug.Log("Attack from shield");
    }
}
