namespace CommandTypesResolver.Validators
{
    internal class InvalidWordValidator : BaseValidator, IValidator
    {
        public void Validate(string input)
        {
            if (input.Trim().Contains(Space))
            {
                // This is not a valid word
                throw new ArgumentException(nameof(input));
            }
        }
    }
}
