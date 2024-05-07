using Sirenix.OdinInspector;
using UnityEngine;

public class ManaComponent : MonoBehaviour, IComponent
{
    [ShowInInspector] private int Mana;
    
    public void Accept(IVistor vistor)
    {
        vistor.Visit(this);
        Debug.Log("ManaComponent Accept");
    }

    public void AddMana(int mana)
    {
        Mana += mana;
    }
}