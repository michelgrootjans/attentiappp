using System;
using System.Collections.Generic;

namespace UniversalRemote
{
    internal class Remote
    {
        private readonly List<IOnCommand> onCommands;
        private readonly List<IOffCommand> offCommands;
        private readonly Stack<ICommand> previousCommands = new Stack<ICommand>();

        public Remote()
        {
            onCommands = new List<IOnCommand>();
            offCommands = new List<IOffCommand>();
        }

        public void On(int buttonNumber)
        {
            if (onCommands.Count > buttonNumber)
            {
                var commandToExecute = onCommands[buttonNumber];
                commandToExecute.Execute();
                previousCommands.Push(commandToExecute);
            }
            else
            {
                Console.WriteLine("Red light... (unknown command)");
            }
        }

        public void Off(int buttonNumber)
        {
            if (offCommands.Count > buttonNumber)
            {
                var commandToExecute = offCommands[buttonNumber];
                commandToExecute.Execute();
                previousCommands.Push(commandToExecute);
            }
            else
            {
                Console.WriteLine("Red light... (unknown command)");
            }
        }

        public void RegisterCommand(IOnCommand onCommand, IOffCommand offCommand)
        {
            onCommands.Add(onCommand);
            offCommands.Add(offCommand);
        }

        public void Undo()
        {
            if (previousCommands.Count != 0)
            {
                var command = previousCommands.Pop();
                command.Undo();
            }
            else
            {
                Console.WriteLine("Red light... (no command to undo)");
            }
        }
    }
}