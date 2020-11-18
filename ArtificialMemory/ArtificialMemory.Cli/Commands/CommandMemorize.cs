using ArtificialMemory.Cli.Commands.Types;
using System.Collections.Generic;

namespace ArtificialMemory.Cli.Commands
{
    public class CommandMemorize : ICommand
    {
        public string Name { get; init; } = "Memorize";

        public Dictionary<string, CommandParameter> Parameters { get; init; } = new()
        {
            { "-t",     new CommandParameter("-t", "--test") },
            { "--test", new CommandParameter("-t", "--test") }
        };

        public void Run()
        {
            throw new System.NotImplementedException();
        }
    }
}
