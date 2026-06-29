using CineFlow.Core.Common;
using CineFlow.Core.Enums;
using CineFlow.Core.Exceptions;

namespace CineFlow.Core.Entities;

public class Ticket : BaseEntity
{
    public Ticket(Guid customerId, Guid showTimeId, Guid seatId, decimal price, TicketStatus status, DateTime purchaseDate)
    {
        CustomerId = customerId;
        ShowTimeId = showTimeId;
        SeatId = seatId;
        Price = price;
        Status = status;
        PurchaseDate = purchaseDate;
    }

    public Guid CustomerId { get; private set; }
    public Guid ShowTimeId { get; private set; }
    public Guid SeatId { get; private set; }
    public decimal Price { get; private set; }
    public TicketStatus Status { get; private set; }
    public DateTime PurchaseDate { get; private set; }

    protected override void Validate()
    {
        if (string.IsNullOrWhiteSpace(CustomerId.ToString()))
            throw new DomainException("CustomerId Is Requirment", "ticket.required_customerId");

        if (string.IsNullOrWhiteSpace(ShowTimeId.ToString()))
            throw new DomainException("ShowTimeId Is Requirment", "ticket.required_showtimeId ");

        if (string.IsNullOrWhiteSpace(SeatId.ToString()))
            throw new DomainException("SeatId Is Requirment", "ticket.required_seatId ");

        if(Price<=0)
            throw new DomainException("Price Can't be Negative", "ticket.Positve_price");

        if(PurchaseDate<DateTime.Now)
            throw new DomainException("PurchaseDate Can't be Past", "ticket.ValidDate_PurchaseDate");

    }
}
