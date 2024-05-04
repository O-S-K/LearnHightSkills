using UnityEngine;

public interface IShield
{
    void Defend();

    static IShield CreateDefault()
    {
        return new Shield();
    }
}


public abstract class ShieldFactory : ScriptableObject
{
    public abstract IShield CreateShield();
}