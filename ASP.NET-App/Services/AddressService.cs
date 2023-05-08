using ASP.NET_App.Models.Entities;
using ASP.NET_App.Models.Identities;
using ASP.NET_App.Repositories;

namespace ASP.NET_App.Services
{
    public class AddressService
    {
        private readonly AddressRepository _addressRepository;
        private readonly UserAddressRepository _userAddressRepository;

        public AddressService(AddressRepository addressRepo, UserAddressRepository userAddressRepository)
        {
            _addressRepository = addressRepo;
            _userAddressRepository = userAddressRepository;
        }

        public async Task<AddressEntity> GetorCreateAsync(AddressEntity addressEntity)
        {
            var entity = await _addressRepository.GetAsync(x =>
            x.StreetName == addressEntity.StreetName &&
            x.PostalCode == addressEntity.PostalCode &&
            x.City == addressEntity.City
            );

            entity ??= await _addressRepository.AddAsync(addressEntity);
            return entity!;
        }

        public async Task AddAddressAsync(AppUser user, AddressEntity addressEntity)
        {
            await _userAddressRepository.AddAsync(new UserAddressEntity
            {
                UserId = user.Id,
                AddressId = addressEntity.Id,
            });
        }
    }
}
