using System;
using System.Collections.Generic;
using UnityEngine;

public class VisitorManager : MonoBehaviour
{
    private void Start()
    {
        List<IComponent> components = new List<IComponent>
        {
            new ConcreteComponentA(),
            new ConcreteComponentB()
        };

        Debug.Log("The client code works with all visitors via the base Visitor interface:");
        var visitor1 = new ConcreteVisitor1();
        Accepts(components, visitor1);

        Debug.Log("It allows the same client code to work with different types of visitors:");
        var visitor2 = new ConcreteVisitor2();
        Accepts(components, visitor2);
    }

    public void Accepts(List<IComponent> components, IVisitor visitor)
    {
        foreach (var component in components)
        {
            component.Accept(visitor);
        }
    }
}