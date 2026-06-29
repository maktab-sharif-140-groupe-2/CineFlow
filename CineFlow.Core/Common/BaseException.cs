namespace CineFlow.Core.Common;

public abstract class BaseException : Exception
{
    public BaseException(string message, string code, Exception? innerException = null) : base(message, innerException)
    {
        Code = code;
    }

    public string Code { get; }
}
