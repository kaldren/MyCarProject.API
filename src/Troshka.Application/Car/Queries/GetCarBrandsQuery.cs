using AutoMapper;
using MediatR;
using Troshka.Application.Car.Models;
using Troshka.Application.Interfaces;
using Troshka.Domain.Entities.VehicleAggregate.Car;

namespace Troshka.Application.Car.Queries;

public class GetCarBrandsQuery : IRequest<ICollection<CarBrandModel>>
{
}

public class GetCarBrandsQueryHandler : IRequestHandler<GetCarBrandsQuery, ICollection<CarBrandModel>>
{
    private readonly IGenericRepository<CarBrandEntity> _carBrandRepo;
    private readonly IMapper _mapper;

    public GetCarBrandsQueryHandler(IGenericRepository<CarBrandEntity> carBrandRepo, IMapper mapper)
    {
        _carBrandRepo = carBrandRepo;
        _mapper = mapper;
    }

    public async Task<ICollection<CarBrandModel>> Handle(GetCarBrandsQuery request, CancellationToken cancellationToken)
    {
        ICollection<CarBrandEntity> categoryEntity = await _carBrandRepo.GetAsync(p => p.Id != null);

        return _mapper.Map<List<CarBrandModel>>(categoryEntity);
    }
}
