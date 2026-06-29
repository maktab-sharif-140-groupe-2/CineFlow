using CineFlow.Core.Common;
using CineFlow.Core.Enums;
using CineFlow.Core.Exceptions;

namespace CineFlow.Core.Entities;

public class ShowTime : BaseEntity
{
    public ShowTime(Guid movieId, Guid hallId, TimeSpan startTime, TimeSpan endTime, decimal basePrice, ShowStatus status)
    {
        MovieId = movieId;
        HallId = hallId;
        StartTime = startTime;
        EndTime = endTime;
        BasePrice = basePrice;
        Status = status;
    }

    public Guid MovieId { get; private set; }
    public Guid HallId { get; private set; }
    public TimeSpan StartTime { get; private set; }
    public TimeSpan EndTime { get; private set; }
    public decimal BasePrice { get; private set; }
    public ShowStatus Status { get; private set; }

    public List<Ticket> Tickets { get; private set; }
    public Hall Hall { get; private set; }

    protected override void Validate()
    {
        if (string.IsNullOrWhiteSpace(MovieId.ToString()))
            throw new DomainException("MovieId Is Requirment", "showTime.required_MovieId");

        if (string.IsNullOrWhiteSpace(HallId.ToString()))
            throw new DomainException("HallId Is Requirment", "showTime.required_hallId ");

        if ((EndTime-StartTime).TotalHours>6 || (EndTime - StartTime).TotalHours==0&& (EndTime - StartTime).Minutes<30)
            throw new DomainException("Maxmium Show Time Is 6 Hours And Minmum TimeShow Is 30 Minute", "ShowTime.ValidShowTime_ShowDourationTime");

        if (BasePrice <= 0)
            throw new DomainException("BasePrice Can't be Negative", "showTime.Positve_BasePrice");
    }
}
