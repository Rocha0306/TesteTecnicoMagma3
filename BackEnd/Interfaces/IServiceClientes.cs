using BackEnd.DTOs;
using BackEnd.Entities;

namespace BackEnd.Interfaces
{
    public interface IServiceClientes
    {
        public Entities.ClientesEntity AddClientes(DTOs.ClientesDTO clientesDTO);

        public List<Entities.ClientesEntity> GetClientes(); 
    }
}
