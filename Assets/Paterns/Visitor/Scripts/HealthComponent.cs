using UnityEngine;
using Sirenix.OdinInspector;

public class HealthComponent : MonoBehaviour, IComponent
{
    [ShowInInspector] private int Health;
    
    
    public void Accept(IVistor vistor)
    {
        vistor.Visit(this);
        Debug.Log("HealthComponent Accept");
    }
    
    public void AddHealth(int health)
    {
        Health += health;
    }
}