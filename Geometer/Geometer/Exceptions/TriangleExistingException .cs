namespace Geometer.Exceptions;

public class TriangleExistingException : Exception
{
    private static readonly string _message = 
        "There is no such triangle! The sum of any two sides must be greater than the length of the third side.";
    
    public TriangleExistingException()
        : base(_message)
    {

    }
}
