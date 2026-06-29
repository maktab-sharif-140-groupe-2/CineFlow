using CineFlow.Application.Abstractions.Persistance;
using CineFlow.Application.Features.ShowTimes.Interface;

namespace CineFlow.Application.Features.ShowTimes.Implementation;

public class ShowTimeService : IShowTimeService
{
    private readonly IShowTimeRepository _showTimeRepository;

    public ShowTimeService(IShowTimeRepository showTimeRepository)
    {
        _showTimeRepository = showTimeRepository;
    }
}
