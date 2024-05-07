using System.Reflection;
using UnityEngine;

[CreateAssetMenu(fileName = "PowerUpVisitor", menuName = "Visitor/PowerUpVisitor")]
public class PowerUpData : ScriptableObject, IVistor
{
    public int HealthBonus = 10;
    public int ManaBonus = 10;
    
    public void Visit(HealthComponent healthComponent)
    {
        healthComponent.AddHealth(HealthBonus);
        Debug.Log("PowerUp Visit HealthComponent");
    }

    public void Visit(ManaComponent manaComponent)
    {
        manaComponent.AddMana(ManaBonus);
        Debug.Log("PowerUp Visit ManaComponent");
    }

    public void Visit(object o)
    {
        MethodInfo visitMethod = GetType().GetMethod("Visit", new[] {o.GetType()});
        if (visitMethod != null && visitMethod != GetType().GetMethod("Visit", new[] {typeof(object)}))
        {
            visitMethod.Invoke(this, new[] {o});
        }
        else
        {
            Debug.LogError("No Visit method found for " + o.GetType());
        }
    }
}