using CineFlow.Core.Common;
using CineFlow.Core.Enums;
using CineFlow.Core.Exceptions;

namespace CineFlow.Core.Entities;

public class Customer : BaseEntity
{
    public Customer(string firstName, string lastName, string phoneNumber, string email, string passwordHash)
    {
        FirstName = firstName;
        LastName = lastName;
        PhoneNumber = phoneNumber;
        Email = email;
        PasswordHash = passwordHash;
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public string PhoneNumber { get; private set; }
    public string Email { get; private set; }
    public string PasswordHash { get; private set; }
    public CustomerRole Role { get; private set; }
    

    public List<Ticket> Tickets { get; private set; }
   


    protected override void Validate()
    {
        if (string.IsNullOrWhiteSpace(FirstName))
            throw new DomainException("FirstName Is Requirment", "customer.required_firstName");

        if (string.IsNullOrWhiteSpace(LastName))
            throw new DomainException("LastName Is Requirment", "customer.required_lastName ");

        if (string.IsNullOrWhiteSpace(PhoneNumber))
            throw new DomainException("PhoneNumber Is Requirment", "customer.required_phoneNumber ");

        if (string.IsNullOrWhiteSpace(Email))
            throw new DomainException("Email Is Requirment", "customer.required_email");

        if(PhoneNumber.Length!=11)
            throw new DomainException("PhoneNumber Length Most be 11", "customer.invalid_phoneNumber_length");

        if (!PhoneNumber.Any(char.IsDigit))
            throw new DomainException("PhoneNumber Most be Digit", "customer.invalid_phoneNumber_format");

        if (!Email.Any(x=> x=='@'))
            throw new DomainException("Email Most Includ @", "customer.invalid_Email_format");

    }
}
