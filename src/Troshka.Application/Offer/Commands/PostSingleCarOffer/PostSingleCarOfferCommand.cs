//using AutoMapper;
//using Azure.Identity;
//using MediatR;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Graph;
//using System.Net.Http.Headers;
//using Troshka.Application.Interfaces;
//using Troshka.Application.Offer.Models;
//using Troshka.Domain.Entities.OwnerAggregate;
//using Troshka.Domain.Entities.VehicleAggregate.Car;

//namespace Troshka.Application.Offer.Commands.PostSingleCarOffer
//{
//    public class PostSingleCarOfferCommand : IRequest<CarOfferModel>
//    {
//        public CarOfferModel Model { get; set; }
//    }

//    public class PostSingleCarOfferCommandHandler : IRequestHandler<PostSingleCarOfferCommand, CarOfferModel>
//    {
//        private readonly IGenericRepository<CarOfferEntity> _carOfferRepo;
//        private readonly IMapper _mapper;
//        private readonly IConfiguration _config;

//        public PostSingleCarOfferCommandHandler(IGenericRepository<CarOfferEntity> carOfferRepo, IMapper mapper, IConfiguration config)
//        {
//            _carOfferRepo = carOfferRepo;
//            _mapper = mapper;
//            _config = config;
//        }

//        public Task<CarOfferModel> Handle(PostSingleCarOfferCommand request, CancellationToken cancellationToken)
//        {
//            var clientSecretCredential = new ClientSecretCredential(_config["TenantId"], _config["ClientId"], _config["ClientSecret"]);
//            var graphClient = new GraphServiceClient(new DelegateAuthenticationProvider(
//                    requestMessage =>
//                    {
//                        // Append the access token to the request.
//                        requestMessage.Headers.Authorization = new AuthenticationHeaderValue("bearer", clientSecretCredential.GetToken().Result.Token);

//                        // Get event times in the current time zone.
//                        requestMessage.Headers.Add("Prefer", "outlook.timezone=\"" + TimeZoneInfo.Local.Id + "\"");

//                        return Task.CompletedTask;
//                    }));

//            _carOfferRepo.Insert(new CarOfferEntity
//            {
//                Title = request.Model.Title,
//                Description = request.Model.Description,
//                Owner = new OwnerEntity
//                {

//                }
//            });

//            throw new NotImplementedException();
//        }
//    }
//}
