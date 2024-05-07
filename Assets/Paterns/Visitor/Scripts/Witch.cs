using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

// https://softwareengineering.stackexchange.com/questions/397192/cant-i-just-use-interfaces-to-implement-the-visitor-pattern
public class Witch : SerializedMonoBehaviour
{
    [SerializeField]
    private List<IComponent> components = new List<IComponent>();

    private void Start()
    {
        components.Add(gameObject.GetOrAdd<HealthComponent>());
        components.Add(gameObject.GetOrAdd<ManaComponent>());
    }

    public void Accept(IVistor vistor)
    {
        foreach (var copomnent in components)
        {
            copomnent.Accept(vistor);
        }
    }
}