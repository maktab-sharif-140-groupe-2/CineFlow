using CineFlow.Core.Common;
using CineFlow.Core.Enums;
using CineFlow.Core.Exceptions;

namespace CineFlow.Core.Entities;

public class Seat : BaseEntity
{
    public Seat(int row, int number, SeatType type, int hallId)
    {
        Row = row;
        Number = number;
        Type = type;
        HallId = hallId;

        Validate(); 
    }

    public int Row { get; private set; }

    public int Number { get; private set; }

    public SeatType Type { get; private set; }

    //Foriegn Key
    public int HallId { get; private set; }

    //Navigtion Properties
    public virtual Hall Hall { get; private set; }

    protected override void Validate()
    {
        if (Row < 0 || Row > 60)
            throw new DomainException("Seat Row must be higher than 0 or lower than 60", "hall.invalid_row_interval");

        if (Number < 0 || Number > 3000)
            throw new DomainException("Seat Number must be higher than 0 or lower than 3000", "hall.invalid_number_interval");

        if (HallId < 0)
            throw new DomainException("Seat HallId must be higher than 0", "hall.invalid_hallId_interval");
    }
}