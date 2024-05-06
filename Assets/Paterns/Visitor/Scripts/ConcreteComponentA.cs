public class ConcreteComponentA : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteA(this);
    }
    
    public string ExclusiveMethodOfConcreteComponentA()
    {
        return "A";
    }
}