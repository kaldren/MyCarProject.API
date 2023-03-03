using AutoMapper;
using MediatR;
using Troshka.Application.Interfaces;
using Troshka.Application.Offer.Models;
using Troshka.Domain.Entities.RegionAggregate;

namespace Troshka.Application.Region.Queries;

public class GetRegionsQuery : IRequest<ICollection<RegionModel>>
{
}

public class GetRegionsQueryHandler : IRequestHandler<GetRegionsQuery, ICollection<RegionModel>>
{
    private readonly IGenericRepository<RegionEntity> _regionRepo;
    private readonly IMapper _mapper;

    public GetRegionsQueryHandler(IGenericRepository<RegionEntity> regionRepo, IMapper mapper)
    {
        _regionRepo = regionRepo;
        _mapper = mapper;
    }

    public async Task<ICollection<RegionModel>> Handle(GetRegionsQuery request, CancellationToken cancellationToken)
    {
        ICollection<RegionEntity> regionEntity = await _regionRepo.GetAsync(p => p.Id != null);

        return _mapper.Map<ICollection<RegionModel>>(regionEntity);
    }
}
