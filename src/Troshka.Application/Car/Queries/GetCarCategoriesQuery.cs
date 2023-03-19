using AutoMapper;
using MediatR;
using Troshka.Application.Car.Models;
using Troshka.Application.Interfaces;
using Troshka.Domain.Entities.VehicleAggregate.Car;

namespace Troshka.Application.Car.Queries;

public class GetCarCategoriesQuery : IRequest<ICollection<CarCategoryModel>>
{
}

public class GetCarCategoriesQueryHandler : IRequestHandler<GetCarCategoriesQuery, ICollection<CarCategoryModel>>
{
    private readonly IGenericRepository<CarCategoryEntity> _carBrandRepo;
    private readonly IMapper _mapper;

    public GetCarCategoriesQueryHandler(IGenericRepository<CarCategoryEntity> carBrandRepo, IMapper mapper)
    {
        _carBrandRepo = carBrandRepo;
        _mapper = mapper;
    }

    public async Task<ICollection<CarCategoryModel>> Handle(GetCarCategoriesQuery request, CancellationToken cancellationToken)
    {
        ICollection<CarCategoryEntity> categoryEntity = await _carBrandRepo.GetAsync(p => p.Id != null);

        return _mapper.Map<List<CarCategoryModel>>(categoryEntity);
    }
}
