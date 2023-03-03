using AutoMapper;
using MediatR;
using Troshka.Application.Car.Models;
using Troshka.Application.Interfaces;
using Troshka.Domain.Entities.VehicleAggregate.Car;

namespace Troshka.Application.Car.Queries;

public class GetCarModelsQuery : IRequest<ICollection<CarModelModel>>
{
    public string BrandId { get; set; }
}

public class GetCarModelsQueryHandler : IRequestHandler<GetCarModelsQuery, ICollection<CarModelModel>>
{
    private readonly IGenericRepository<CarModelEntity> _carModelRepo;
    private readonly IMapper _mapper;

    public GetCarModelsQueryHandler(IGenericRepository<CarModelEntity> carModelRepo, IMapper mapper)
    {
        _carModelRepo = carModelRepo;
        _mapper = mapper;
    }

    public async Task<ICollection<CarModelModel>> Handle(GetCarModelsQuery request, CancellationToken cancellationToken)
    {
        ICollection<CarModelEntity> categoryEntity = await _carModelRepo.GetAsync(p => p.CarBrandId == request.BrandId);

        return _mapper.Map<List<CarModelModel>>(categoryEntity);
    }
}
