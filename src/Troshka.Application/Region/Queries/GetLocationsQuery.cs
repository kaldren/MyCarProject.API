using AutoMapper;
using MediatR;
using Troshka.Application.Interfaces;
using Troshka.Application.Offer.Models;
using Troshka.Domain.Entities.RegionAggregate;

namespace Troshka.Application.Region.Queries;

public class GetLocationsQuery : IRequest<ICollection<LocationModel>>
{
    public string RegionId { get; set; }
}

public class GetLocationsQueryQueryHandler : IRequestHandler<GetLocationsQuery, ICollection<LocationModel>>
{
    private readonly IGenericRepository<LocationEntity> _locationRepo;
    private readonly IMapper _mapper;

    public GetLocationsQueryQueryHandler(IGenericRepository<LocationEntity> locationRepo, IMapper mapper)
    {
        _locationRepo = locationRepo;
        _mapper = mapper;
    }

    public async Task<ICollection<LocationModel>> Handle(GetLocationsQuery request, CancellationToken cancellationToken)
    {
        ICollection<LocationEntity> locationsEntity = await _locationRepo.GetAsync(p => p.RegionId == request.RegionId);

        return _mapper.Map<ICollection<LocationModel>>(locationsEntity);
    }
}
