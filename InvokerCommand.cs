using System;
using System.Collections.Generic;

namespace Task_dev8.Commands
{
    class InvokerCommand
    {
        ICommand command;

        public void SetCommand(ICommand com)
        {
            command = com;
        }

        public void ExecuteCommand(List<User> list)
        {
            command.Execute(list);
        }
    }
}