namespace DigitalWonderlabInterview.Service.Exceptions;

public class ValidationFailedException : Exception
{
    public ValidationFailedException(string reason) : base(reason)
        { }
}