using AutoMapper;
using MediatR;
using Troshka.Application.Car.Models;
using Troshka.Application.Interfaces;
using Troshka.Domain.Entities.VehicleAggregate.Car;

namespace Troshka.Application.Car.Queries;

public class GetCarTransmissionModelQuery : IRequest<ICollection<CarTransmissionModel>>
{
}

public class GetCarTransmissionModelQueryHandler : IRequestHandler<GetCarTransmissionModelQuery, ICollection<CarTransmissionModel>>
{
    private readonly IGenericRepository<CarTransmissionEntity> _carTransmissionRepo;
    private readonly IMapper _mapper;

    public GetCarTransmissionModelQueryHandler(IGenericRepository<CarTransmissionEntity> carTransmissionRepo, IMapper mapper)
    {
        _carTransmissionRepo = carTransmissionRepo;
        _mapper = mapper;
    }

    public async Task<ICollection<CarTransmissionModel>> Handle(GetCarTransmissionModelQuery request, CancellationToken cancellationToken)
    {
        ICollection<CarTransmissionEntity> transmissionEntity = await _carTransmissionRepo.GetAsync(p => p.Id != null);

        return _mapper.Map<List<CarTransmissionModel>>(transmissionEntity);
    }
}
