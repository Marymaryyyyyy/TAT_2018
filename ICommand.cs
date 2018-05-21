using System;
using System.Collections.Generic;

namespace Task_dev8.Commands
{
    interface ICommand
    {
        void Execute(List<User> list);
    }
}