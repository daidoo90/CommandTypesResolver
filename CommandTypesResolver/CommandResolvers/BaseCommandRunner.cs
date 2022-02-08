using CommandTypesResolver.Validators;

namespace CommandTypesResolver.CommandResolvers
{
    internal abstract class BaseCommandRunner : ICommandRunner
    {
        protected abstract IEnumerable<IValidator> Validators { get; }

        public string Run(string input)
        {
            this.Validate(input);

            string output = this.RunCore(input);
            return output;
        }

        protected abstract string RunCore(string input);

        private void Validate(string input)
        {
            if (!this.Validators?.Any() ?? false)
                return;

            foreach (var validator in this.Validators)
            {
                validator.Validate(input);
            }
        }
    }
}
