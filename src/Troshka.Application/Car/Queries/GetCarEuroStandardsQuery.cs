using AutoMapper;
using MediatR;
using Troshka.Application.Car.Models;
using Troshka.Application.Interfaces;
using Troshka.Domain.Entities.VehicleAggregate.Car;

namespace Troshka.Application.Car.Queries;

public class GetCarEuroStandardsQuery : IRequest<ICollection<CarEuroStandardModel>>
{
}

public class GetCarEuroStandardsQueryHandler : IRequestHandler<GetCarEuroStandardsQuery, ICollection<CarEuroStandardModel>>
{
    private readonly IGenericRepository<CarEuroStandardEntity> _standardRepo;
    private readonly IMapper _mapper;

    public GetCarEuroStandardsQueryHandler(IGenericRepository<CarEuroStandardEntity> standardRepo, IMapper mapper)
    {
        _standardRepo = standardRepo;
        _mapper = mapper;
    }

    public async Task<ICollection<CarEuroStandardModel>> Handle(GetCarEuroStandardsQuery request, CancellationToken cancellationToken)
    {
        ICollection<CarEuroStandardEntity> standardEntity = await _standardRepo.GetAsync(p => !string.IsNullOrEmpty(p.Id));

        return _mapper.Map<List<CarEuroStandardModel>>(standardEntity);
    }
}
