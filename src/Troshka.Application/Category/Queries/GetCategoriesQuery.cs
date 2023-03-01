using AutoMapper;
using MediatR;
using Troshka.Application.Category.Models;
using Troshka.Application.Interfaces;
using Troshka.Domain.Entities.VehicleAggregate;

namespace Troshka.Application.Category.Queries
{
    public class GetCategoriesQuery : IRequest<ICollection<CategoryModel>>
    {

    }

    public class GetCategoriesQueryQueryHandler : IRequestHandler<GetCategoriesQuery, ICollection<CategoryModel>>
    {
        private readonly IGenericRepository<CategoryEntity> _categoryRepo;
        private readonly IMapper _mapper;

        public GetCategoriesQueryQueryHandler(IGenericRepository<CategoryEntity> categoryRepo, IMapper mapper)
        {
            _categoryRepo = categoryRepo;
            _mapper = mapper;
        }

        public async Task<ICollection<CategoryModel>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            ICollection<CategoryEntity> categoryEntity = await _categoryRepo.GetAsync(p => p.Id != null);

            return _mapper.Map<List<CategoryModel>>(categoryEntity);
        }
    }
}
