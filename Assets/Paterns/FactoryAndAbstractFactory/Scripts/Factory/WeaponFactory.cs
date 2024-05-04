using UnityEngine;

public interface IWeapon
{
    void Attack();

    static IWeapon CreateDefault()
    {
        return new Sword();
    }
}

 
 
public abstract class WeaponFactory : ScriptableObject
{
    public abstract IWeapon CreateWeapon();
}