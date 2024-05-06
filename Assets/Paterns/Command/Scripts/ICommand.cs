using System.Threading.Tasks;
using UnityEngine;

public interface ICommand
{
    Task Execute();
    Task Undo();
}

public abstract class HeroCommand : ICommand
{
    protected readonly Entity hero;

    protected HeroCommand(Entity hero)
    {
        this.hero = hero;
    }

    public abstract Task Execute();
    public abstract Task Undo();

    public static T Create<T>(object hero) where T : HeroCommand
    {
        return (T)System.Activator.CreateInstance(typeof(T), hero);
    }
}


public class AttackCommand : HeroCommand
{
    public AttackCommand(Entity hero) : base(hero)
    {
    }

    public override async Task Execute()
    {
        hero.Attack();
    }

    public override async Task Undo()
    {
    }
}

public class JumpCommand : HeroCommand
{
    public JumpCommand(Entity hero) : base(hero)
    {
    }

    public override async Task Execute()
    {
        hero.Jump();
    }

    public override async Task Undo()
    {
    }
}

public class RunCommand : HeroCommand
{
    
    public RunCommand(Entity hero) : base(hero)
    {
    }

    public override async Task Execute()
    {
        Debug.Log("Start Run Command");
        hero.Run(hero.transform.position + Vector3.one);
        
        Debug.Log("Wait for 0.1s");
        await Task.Delay(100);
        
        hero.Idle();
        Debug.Log("End Run Command");
    }

    public override async Task Undo()
    {
        Debug.Log("Start Undo Command");
        hero.Idle();
        
        Debug.Log("Wait for 0.1s");
        await Task.Delay(100); 
        
        hero.Run(hero.transform.position - Vector3.one);
        Debug.Log("End Undo Command");
    }
}