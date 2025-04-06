using AutoMapper;
using BackEnd.DTOs;
using BackEnd.Entities;
using BackEnd.Interfaces;

namespace BackEnd.Service
{
    public class ServiceClientes : IServiceClientes 
    {
        private readonly IMapper mapper; 

        private readonly IMongoRepository repository;   
        public ServiceClientes(IMapper _mapper, IMongoRepository mongoRepository)
        {
            mapper = _mapper;
            repository = mongoRepository;   
        }
        public Entities.ClientesEntity AddClientes(DTOs.ClientesDTO clientesDTO)
        {
            Entities.ClientesEntity clientesEntity = new Entities.ClientesEntity();
            mapper.Map(clientesDTO, clientesEntity);
            var clientedatabase = repository.EncontraCliente(clientesEntity); 
            if(clientesEntity.Equals(clientedatabase))
            {
                throw new BadHttpRequestException("Cliente já no banco"); 
            }

            else
            {
                repository.AdicionarCliente(clientesEntity);
                return clientesEntity; 
            }

        }
        public List<ClientesEntity> GetClientes()
        {
            return repository.ObterTodos(); 
        }

      
    }
}
