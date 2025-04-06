using System.Text.Json.Serialization;

namespace BackEnd.APIs
{
    public class ResponseAPI
    {
        public bool sucess {  get; set; }   
        public List<DataResponseAPI> data { get; set; }

    }
}
