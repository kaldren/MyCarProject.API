using AutoMapper;
using MediatR;
using Troshka.Application.Car.Models;
using Troshka.Application.Interfaces;
using Troshka.Domain.Entities.VehicleAggregate.Car;

namespace Troshka.Application.Car.Queries;

public class GetCarEnginesModelQuery : IRequest<ICollection<CarEngineModel>>
{
}

public class GetCarEnginesModelQueryHandler : IRequestHandler<GetCarEnginesModelQuery, ICollection<CarEngineModel>>
{
    private readonly IGenericRepository<CarEngineEntity> _carEngineRepo;
    private readonly IMapper _mapper;

    public GetCarEnginesModelQueryHandler(IGenericRepository<CarEngineEntity> carEngineRepo, IMapper mapper)
    {
        _carEngineRepo = carEngineRepo;
        _mapper = mapper;
    }

    public async Task<ICollection<CarEngineModel>> Handle(GetCarEnginesModelQuery request, CancellationToken cancellationToken)
    {
        ICollection<CarEngineEntity> carEngineEntity = await _carEngineRepo.GetAsync(p => p.Id != null);

        return _mapper.Map<List<CarEngineModel>>(carEngineEntity);
    }
}
