namespace DrawingProgram
{
    public class Command
    {
        public string CmdName { get; set; }
        public int[] CmdParameters { get; set; }

        public Command(string cmdName, int[] cmdParameters)
        {
            CmdName = cmdName;
            CmdParameters = cmdParameters;
        }
    }
}
