using AutoMapper;
using MediatR;
using Troshka.Application.Interfaces;
using Troshka.Application.Offer.Models;
using Troshka.Domain.Entities.VehicleAggregate.Car;

namespace Troshka.Application.Offer.Queries.GetSingleCarOffer
{
    public class GetSingleCarOfferQuery : IRequest<CarOfferModel>
    {
        public string OfferId { get; set; }
    }

    public class GetSingleCarOfferQueryQueryHandler : IRequestHandler<GetSingleCarOfferQuery, CarOfferModel>
    {
        private readonly IGenericRepository<CarOfferEntity> _carOfferRepo;
        private readonly IMapper _mapper;

        public GetSingleCarOfferQueryQueryHandler(IGenericRepository<CarOfferEntity> carOfferRepo, IMapper mapper)
        {
            _carOfferRepo = carOfferRepo;
            _mapper = mapper;
        }

        public async Task<CarOfferModel> Handle(GetSingleCarOfferQuery request, CancellationToken cancellationToken)
        {
            CarOfferEntity? offerEntity = await _carOfferRepo.GetAsync(request.OfferId);

            return _mapper.Map<CarOfferModel>(offerEntity);
        }
    }
}
