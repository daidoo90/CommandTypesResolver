using CommandTypesResolver.Validators;
using System.Text;

namespace CommandTypesResolver.CommandResolvers
{
    internal class SentenceCommandRunner : BaseCommandRunner
    {
        protected override IEnumerable<IValidator> Validators => new List<IValidator>()
        {
            new NullValidator(),
            new InvalidSentenceValidator()
        };

        protected override string RunCore(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }

            var words = input.Split(' ');
            if (!words?.Any() ?? false)
            {
                throw new Exception("Not valid input.");
            }

            int wordsCount = words.Count();
            StringBuilder builder = new StringBuilder();
            for (int i = wordsCount - 1; i >= 0; i--)
            {
                var currentWord = words[i];
                builder.Append($"{currentWord} ");
            }

            return builder.ToString();
        }
    }
}
