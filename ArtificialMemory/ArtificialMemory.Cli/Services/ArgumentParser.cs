using ArtificialMemory.Cli.Commands;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArtificialMemory.Cli.Services
{
    public class ArgumentParser
    {
        private Dictionary<string, ICommand> m_CommandMap { get; init; } = new();

        public ArgumentParser(List<ICommand> commands)
        {
            commands.ForEach(x => m_CommandMap.Add(x.Name.ToLower(), x));
        }

        internal void Parse(string[] args)
        {
            if (args.Length == 0)
                return;

            var commandName = args[0].ToLower();
            Console.WriteLine($"Command: {commandName}");

            if (m_CommandMap.ContainsKey(commandName))
                Console.WriteLine("Command found!");

            for(int i = 1; i < args.Length; i++)
            {
                var v = args[i];
                if (!v.StartsWith('-'))
                    Console.WriteLine("invalid parameter");

                Console.WriteLine($"Parameter: {v}");
            }
        }
    }
}
