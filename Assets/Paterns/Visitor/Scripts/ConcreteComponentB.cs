public class ConcreteComponentB : IComponent
{
    public void Accept(IVisitor visitor)
    {
        visitor.VisitConcreteB(this);
    }
    
    
    public string SpecialMethodOfConcreteComponentB()
    {
        return "B";
    }
}