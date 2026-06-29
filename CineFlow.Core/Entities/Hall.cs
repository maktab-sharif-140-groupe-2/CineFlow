using CineFlow.Core.Common;
using CineFlow.Core.Exceptions;

namespace CineFlow.Core.Entities;

public class Hall : BaseEntity
{
    public Hall(string name, int capacity, Guid cinemaId)
    {
        Name = name;
        Capacity = capacity;
        CinemaId = cinemaId;

        Validate();
    }


    public string Name { get; private set; }

    public int Capacity { get;private set; }

    //Forigen Key
    public Guid CinemaId { get; private set; }

    //Navigation Porperties 
    public virtual Cinema Cinema { get; private set; }

    public List<ShowTime> ShowTimes { get; private set; }

    public List<Seat> Seats { get; private set; }

    protected override void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
            throw new DomainException("the hall name is required", "hall.required_City");

        if (Name.Length < 3 || Name.Length > 25)
            throw new DomainException("hall name length must be higher than 3 or lower than 25 characters", "hall.invalid_name_length");

        if (Capacity < 0 || Capacity > 30_000)
            throw new DomainException("hall Capacity must be higher than 0 or lower than 30_000", "hall.invalid_capacity_interval");
    }
}


//CinemaId
//Name
//Capacity