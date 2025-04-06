using BackEnd.APIs;

namespace BackEnd.Interfaces
{
    public interface IServiceFiltro
    {
        public List<DataResponseAPI> FiltroMaquinas(ResponseAPI responseAPI);
    }
}
