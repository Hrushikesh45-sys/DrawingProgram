using System;
using System.Collections.Generic;
using System.Linq;

namespace DrawingProgram
{
    public class Parser
    {
        public Command Parse(string input)
        {
            input = input.Trim().ToLower();
            string[] split = input.ToLower().Split(' ');

            // Invalid when no words are passed
            if (input.Equals(""))
                throw new ArgumentException("No commands entered");

            // Invalid when more than 3 words are passed to the parser
            if (split.Length > 3)
                throw new ArgumentException("Please enter less than 3 words");

            int[] parameters = new int[split.Length - 1];
            for (int i = 1; i < split.Length; i++)
            {
                if (!int.TryParse(split[i], out parameters[i - 1]))
                    throw new Exception("ERROR: Invalid parameter.");
            }

            string[] validCommands = { "rectangle", "square", "circle", "triangle", "drawto", "moveto", "reset", "clear", "fillon", "filloff", "penred", "pengreen", "penyellow", "penblue", "penpink", "run" };

            //Check if split[0] is a part of validCommands
            if (!validCommands.Contains(split[0]))
                throw new ArgumentException("Invalid command");

            string cmdName = split[0];
            return new Command(cmdName, parameters);
        }

        public List<Command> ParseInput_MultiLine(string inputFull)
        {
            // Splits the multi-line string by a new line and stores this in a new list
            var commandsList = new List<Command>();
            var inputSplitByLines = inputFull.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries); // Windows splits newlines by '\r\n' so here we split by 2 chars and remove any empty string split entries

            // Loops around the list of commands, calling the single line parser on every element in the commandsList list
            inputSplitByLines.ToList().ForEach(input => commandsList.Add(Parse(input))); // ForEach command from System.LINQ used here instead of a typical for-each loop
            return commandsList;
        }
    }
}
