using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker
{
    private Command m_Command;
    public bool DisableLog = false;

    public void SetCommand(Command command)
    {
        m_Command = command;
    }

    public void ExecuteCommand()
    {
        //If we are doing our replay, do not redo this Queue
        if (!DisableLog)
        {
            CommandLog.commands.Enqueue(m_Command);
        }
        
        m_Command.Execute();
    }
}
