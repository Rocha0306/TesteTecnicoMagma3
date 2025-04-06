using System.Text.Json.Serialization;

namespace BackEnd.APIs
{
    public class DataResponseAPI
    {
        public string Id { get; set; }

        public string Name { get; set; }

        [JsonPropertyName("Agent.DataLastCommunication")]
        public string UltimaComunicaoMaquina { get; set; }

    }
}
