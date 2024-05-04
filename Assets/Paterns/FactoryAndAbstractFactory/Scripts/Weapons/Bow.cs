using UnityEngine;

public class Bow : IWeapon
{
    public void Attack()
    {
        Debug.Log("Shooting the arrow");
    }
}