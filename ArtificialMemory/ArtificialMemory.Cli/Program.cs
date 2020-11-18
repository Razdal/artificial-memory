using ArtificialMemory.Cli.Commands;
using ArtificialMemory.Cli.Services;
using System;
using System.Collections.Generic;

namespace ArtificialMemory.Cli
{
    class Program
    {
        static void Main(string[] args)
        {
            var commands = new List<ICommand>
            {
                new CommandMemorize()
            };

            var parser = new ArgumentParser(commands);
            parser.Parse(args);
        }
    }
}
