using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjection
{
    public class CompositionRoot : ICompositionRoot
    {
        // We will do fancier stuff here in just a bit...
        readonly IConsoleWriter consoleWriter;

        public CompositionRoot(IConsoleWriter consoleWriter)
        {
            this.consoleWriter = consoleWriter;
            consoleWriter.LogMessage("Hello from CompositionRoot Constructor!");
        }

        public void LogMessage(string message)
        {
            consoleWriter.LogMessage(message);
        }
    }
}
