using CineFlow.Core.Common;
using CineFlow.Core.Exceptions;

namespace CineFlow.Core.Entities;

public class Cinema : BaseEntity
{
    public Cinema(string name, string address, string city)
    {
        Name = name;
        Address = address;
        City = city;

        Validate();
    }

    public string Name { get; private set; }

    public string Address { get; private set; }

    public string City { get; private set; }

    protected override void Validate()
    {
        if (string.IsNullOrWhiteSpace(Name))
            throw new DomainException("the cinema name is required", "cinema.required_Name");

        if (string.IsNullOrWhiteSpace(Address))
            throw new DomainException("the Address is required", "cinema.required_Address");

        if (string.IsNullOrWhiteSpace(City))
            throw new DomainException("the City is required", "cinema.required_City");

        if (Name.Length < 3 || Name.Length > 25)
            throw new DomainException("cinema name length must be higher than 3 or lower than 25 characters", "cinema.invalid_name_length");

        if (Address.Length < 3 || Address.Length > 100)
            throw new DomainException("cinema address length must be higher than 3 or lower than 100 characters", "cinema.invalid_address_length");

        if (City.Length < 3 || City.Length > 230)
            throw new DomainException("cinema city length must be higher than 3 or lower than 30 characters", "cinema.invalid_city_length");
    }
}
