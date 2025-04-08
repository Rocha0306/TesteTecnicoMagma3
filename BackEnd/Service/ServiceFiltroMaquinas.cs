using BackEnd.APIs;
using BackEnd.Interfaces;
using MongoDB.Bson;

namespace BackEnd.Service
{
    public class ServiceFiltroMaquinas : IServiceFiltro
    {
        public List<DataResponseAPI> FiltroMaquinas(ResponseAPI responseAPI)
        {
            //Máquinas com 60 dias ou mais sem comunica

            DateTimeOffset Menos60Dias = DateTimeOffset.UtcNow.AddDays(-60);

            List<DataResponseAPI> MaquinasFiltradas = new List<DataResponseAPI>();

            int Index = responseAPI.data.Count(); 


            for (int i = 0; i < Index; i++)
            {

                DateTimeOffset dateTimeOffset = DateTimeOffset.Parse(responseAPI.data[i].UltimaComunicaoMaquina);
                int analise = dateTimeOffset.CompareTo(Menos60Dias);

                if (analise == -1) //É antes
                {
                    MaquinasFiltradas.Add(responseAPI.data[i]);
                }

                if(analise == 0)
                {
                    MaquinasFiltradas.Add(responseAPI.data[i]);
                }

                // 0 -> igual a data, -1 -> antes da data

            }

            return MaquinasFiltradas.ToList();   
        }

       
    }
}
