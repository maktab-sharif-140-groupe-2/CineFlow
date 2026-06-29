using CineFlow.Core.Common;
using CineFlow.Core.Enums;
using CineFlow.Core.Exceptions;

namespace CineFlow.Core.Entities;

public class Movie : BaseEntity
{
    public Movie(string title, string description, TimeSpan duration, int ageLimit, Genre genre)
    {
        Title = title;
        Description = description;
        Duration = duration;
        AgeLimit = ageLimit;
        Genre = genre;

        Validate();
    }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public TimeSpan Duration { get; private set; }

    public int AgeLimit { get; private set; }

    public Genre Genre { get; private set; }

    public DateTime ReleaseDate { get; private set; }

    protected override void Validate()
    {
        if (string.IsNullOrWhiteSpace(Title))
            throw new DomainException("the movie Title is required", "movie.required_title");

        if (string.IsNullOrWhiteSpace(Description))
            throw new DomainException("the movie Description is required", "movie.required_description");

        if (Title.Length < 3 || Title.Length > 25)
            throw new DomainException("movie Title length must be higher than 3 or lower than 25 characters", "movie.invalid_title_length");

        if (Description.Length < 3 || Description.Length > 100)
            throw new DomainException("movie Description length must be higher than 3 or lower than 100 characters", "movie.invalid_description_length");

        if ((Duration.Hours == 0 && Duration.Minutes < 10) || Duration.Hours > 4.5)
            throw new DomainException("the duration time cannot be less than 10 minutes or higher than 4.5", "movie.invalid_duration_interval");

        if (AgeLimit < 5 || AgeLimit > 18)
            throw new DomainException("movie AgeLimit must be higher than 5 or lower than 18", "movie.invalid_ageLimit_interval");
    }
}

