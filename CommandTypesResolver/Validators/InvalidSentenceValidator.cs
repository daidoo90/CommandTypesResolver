namespace CommandTypesResolver.Validators
{
    internal class InvalidSentenceValidator : BaseValidator, IValidator
    {
        public void Validate(string input)
        {
            if (!input.Trim().Contains(Space))
            {
                // This is not a valid sentence!
                throw new ArgumentException(nameof(input));
            }
        }
    }
}
