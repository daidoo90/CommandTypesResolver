using CommandTypesResolver.CommandResolvers;

namespace CommandTypesResolver
{
    internal class CommandCentralRunner
    {
        private IDictionary<CommandType, ICommandRunner> _runners =
            new Dictionary<CommandType, ICommandRunner>()
            {
                [CommandType.CommandType1] = new SentenceCommandRunner(),
                [CommandType.CommandType2] = new WordCommandRunner()
            };

        internal string Run(CommandType commandType, string input)
        {
            bool invalidCommandType = this._runners.TryGetValue(commandType, out ICommandRunner? runner);
            if (!invalidCommandType ||
                runner == null)
            {
                throw new ArgumentException(nameof(commandType));
            }

            return runner.Run(input);
        }
    }
}
