namespace CommandTypesResolver.Validators
{
    internal class NullValidator : IValidator
    {
        public void Validate(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                throw new ArgumentNullException(nameof(input));
            }
        }
    }
}
