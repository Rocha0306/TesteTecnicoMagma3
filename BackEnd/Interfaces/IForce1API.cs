using BackEnd.APIs;

namespace BackEnd.Interfaces
{
    public interface IForce1API
    {
        public Task<ResponseAPI> PegaAtivos(); 
    }
}
