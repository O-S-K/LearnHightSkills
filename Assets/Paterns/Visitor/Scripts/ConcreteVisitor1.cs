using UnityEngine;

public class ConcreteVisitor1 : IVisitor
{
    public void VisitConcreteA(ConcreteComponentA component)
    {
        Debug.Log(component.ExclusiveMethodOfConcreteComponentA());
    }

    public void VisitConcreteB(ConcreteComponentB component)
    {
        Debug.Log(component.SpecialMethodOfConcreteComponentB());
    }
}