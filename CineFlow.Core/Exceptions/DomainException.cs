using CineFlow.Core.Common;

namespace CineFlow.Core.Exceptions;

public class DomainException : BaseException
{
    public DomainException(string message, string code, Exception? innerException = null) : base(message, $"DomainException_{code}", innerException)
    {
    }

}
