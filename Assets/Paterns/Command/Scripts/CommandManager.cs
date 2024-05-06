using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using Sirenix.OdinInspector;

public class CommandManager : SerializedMonoBehaviour
{
    public Entity Entity;
    
    public ICommand SingleCommand;
    public List<ICommand> ListCommands = new List<ICommand>();
    
    readonly CommandInvoke commandInvoke = new CommandInvoke();
    private bool isCommandInvoke = false;
    
    private void Start()
    {
         Entity = GetComponent<Entity>();
         SingleCommand = HeroCommand.Create<RunCommand>(Entity);
        
        // ListCommands = new List<ICommand>()
        // {
        //     HeroCommand.Create<RunCommand>(Entity),
        //     HeroCommand.Create<AttackCommand>(Entity),
        //     HeroCommand.Create<JumpCommand>(Entity),
        // };
    }
    

    private async Task ExcuteCommand(List<ICommand> commands)
    {
        isCommandInvoke = true;
        await commandInvoke.ExecuteCommand(commands);
        isCommandInvoke = false;
    }
    
    private async Task UndoCommand(List<ICommand> commands)
    {
        isCommandInvoke = true;
        await commandInvoke.UndoCommand(commands);
        isCommandInvoke = false;
    }


    private void Update()
    {
        if(isCommandInvoke)
            return;

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            ExcuteCommand(new List<ICommand>(){SingleCommand});
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            UndoCommand(new List<ICommand>(){SingleCommand});
        }
        
        // if (Input.GetKeyDown(KeyCode.Alpha1))
        // {
        //     ExcuteCommand(new List<ICommand>(){SingleCommand});
        // }
        // if (Input.GetKeyDown(KeyCode.Alpha2))
        // {
        //     ExcuteCommand(ListCommands);
        // }
    }
}

public class CommandInvoke
{
    private Stack<ICommand> commandStack = new Stack<ICommand>();

    public async Task ExecuteCommand(List<ICommand> commands)
    {
        foreach (var command in commands)
        {
            commandStack.Push(command);
            await command.Execute();
        }
    }
    
    public async Task UndoCommand(List<ICommand> commands)
    {
        foreach (var command in commands)
        {
            if (commandStack.Count == 0)
            {
                Debug.Log("No commands to undo.");
                return;
            }
        
            commandStack.Pop();
            await command.Undo();
        }
    }
}