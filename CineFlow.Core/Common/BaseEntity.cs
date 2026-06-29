namespace CineFlow.Core.Common;

public abstract class BaseEntity
{

    public Guid Id { get; private set; }

    public bool IsDelete { get; set; }

    public DateTime? DeleteAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public DateTime CreatedAt { get; set; }

    protected abstract void Validate();

    public void Delete()
    {
        IsDelete = true;
        DeleteAt = DateTime.UtcNow;
        ModifiedAt = DateTime.UtcNow;

    }


}
