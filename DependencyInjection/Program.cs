using System;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
//https://www.codementor.io/@copperstarconsulting/getting-started-with-dependency-injection-using-castle-windsor-4meqzcsvh
namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var container = new WindsorContainer();

            // Register the CompositionRoot type with the container
            container.Register(Component.For<ICompositionRoot>().ImplementedBy<CompositionRoot>());
            container.Register(Component.For<IConsoleWriter>().ImplementedBy<ConsoleWriter>());
            container.Register(Component.For<ISingletonDemo>().ImplementedBy<SingletonDemo>());

            // Resolve an object of type ICompositionRoot (ask the container for an instance)
            // This is analagous to calling new() in a non-IoC application.
            var root = container.Resolve<ICompositionRoot>();

          

            root.LogMessage("Hello from my very first resolved class!");

            var x = new CompositionRoot(new ConsoleWriter(new SingletonDemo()));
            x.LogMessage("Thai test");

            // Wait for user input so they can check the program's output.
            Console.ReadLine();
            //Console.WriteLine("Hello World!");
        }
    }
}
