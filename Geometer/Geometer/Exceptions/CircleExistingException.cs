namespace Geometer.Exceptions;

public class CircleExistingException : Exception
{
    private static readonly string _message =
        "There is no such circle! Radius must be greater than zero.";

    public CircleExistingException()
        : base(_message)
    {

    }
}
