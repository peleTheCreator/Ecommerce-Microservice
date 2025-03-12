using AutoMapper;
using Ecommerce.UserMS.Application.Persisitance.Abstraction;
using Ecommerce.UserMS.Application.Service.Abstraction;
using Ecommerce.UserMS.Domain.Entities;
using Ecommerce.UserMS.Domain.Model.RequestDto;
using Ecommerce.UserMS.Domain.Model.ResponseDto;

namespace Ecommerce.UserMS.Application.Service.Concrete
{
    internal class UsersService : IUsersService
    {
        private readonly IUsersRepository _usersRepository;
        private readonly IMapper _mapper;

        public UsersService(IUsersRepository usersRepository, IMapper mapper)
        {
            _usersRepository = usersRepository;
            _mapper = mapper;
        }

        public async Task<UserDTO> GetUserByUserID(Guid userID)
        {
            ApplicationUser? user = await _usersRepository.GetUserByUserID(userID);
            return _mapper.Map<UserDTO>(user);
        }

        public async Task<List<UserDTO>> GetUsers()
        {
            List<ApplicationUser> user = await _usersRepository.GetUsers();
            return _mapper.Map<List<UserDTO>>(user);
        }

        public async Task<AuthenticationResponse?> Login(LoginRequest loginRequest)
        {
            ApplicationUser? user = await _usersRepository.GetUserByEmailAndPassword(loginRequest.Email, loginRequest.Password);

            if (user == null)
            {
                return null;
            }
            return _mapper.Map<AuthenticationResponse>(user) with { Success = true, Token = "token" };
        }


        public async Task<AuthenticationResponse?> Register(RegisterRequest registerRequest)
        {
            ApplicationUser user = _mapper.Map<ApplicationUser>(registerRequest);
            ApplicationUser? registeredUser = await _usersRepository.AddUser(user);
            if (registeredUser == null)
            {
                return null;
            }
            return _mapper.Map<AuthenticationResponse>(registeredUser) with { Success = true, Token = "token" };
        }
    }
}
