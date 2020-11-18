using ArtificialMemory.Cli.Commands.Types;
using System.Collections.Generic;

namespace ArtificialMemory.Cli.Commands
{
    // Commands
    // [] memorize
    //      - Memorize content that is on clipboard
    // [] memorize "Content"
    //      - Memorize typed content for later use
    // Command Options
    //      -d --description : "Description" -> Short description related to memorized object
    // [] forget
    //      - Forgets the last memorized item
    // [] remind
    //      - Lists memorized objects
    // [] clear
    //      - Clears active memory, memoried objects will still be archieved
    public interface ICommand
    {
        string Name { get; }
        Dictionary<string, CommandParameter> Parameters { get; }

        void Run();
    }
}
