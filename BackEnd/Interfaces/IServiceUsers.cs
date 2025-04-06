using BackEnd.DTOs;

namespace BackEnd.Interfaces
{
    public interface IServiceUsers
    {
        public TokenDTO Login(UsersDTO usersDTO);
    }
}
