using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public interface IConsoleWriter
    {
        void LogMessage(string message);
    }
}
