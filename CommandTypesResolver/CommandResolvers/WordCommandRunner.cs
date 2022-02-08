using CommandTypesResolver.Validators;
using System.Text;

namespace CommandTypesResolver.CommandResolvers
{
    internal class WordCommandRunner : BaseCommandRunner
    {
        protected override IEnumerable<IValidator> Validators => new List<IValidator>()
        {
            new NullValidator(),
            new InvalidWordValidator()
        };

        protected override string RunCore(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }

            int wordCount = input.Count();
            StringBuilder builder = new StringBuilder();
            for (int i = wordCount - 1; i >= 0; i--)
            {
                var currentCharacter = input[i];
                builder.Append($"{currentCharacter}");
            }

            return builder.ToString();
        }
    }
}
