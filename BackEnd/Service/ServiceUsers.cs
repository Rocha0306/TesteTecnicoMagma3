using AutoMapper;
using BackEnd.DTOs;
using BackEnd.Entities;
using BackEnd.Interfaces;

namespace BackEnd.Service
{
    public class ServiceUsers : IServiceUsers
    {

        public IMapper mapper;

        public IMongoRepository repository; 

        public ITokenService tokenService;

        public ServiceUsers(IMapper _mapper, IMongoRepository _mongoRepository, ITokenService _tokenService)
        {
            mapper = _mapper;   
            repository = _mongoRepository;
            tokenService = _tokenService;   

        }
        public TokenDTO Login(UsersDTO usersDTO)
        {

          
            UsersEntity usersEntity = new UsersEntity();
            mapper.Map(usersDTO, usersEntity);
            var responsedatabase = repository.FindUsers(usersEntity);

            if (responsedatabase == null)
            {
                throw new BadHttpRequestException("User is not in Database");
            }
            string Token = tokenService.GeneratorToken();
            return new TokenDTO(Token); 

           
          


        }
    }
}
