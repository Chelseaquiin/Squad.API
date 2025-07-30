using System.Text.Json.Serialization;

namespace Squad.Models.Dtos.Responses
{
    public class LookUpResponse
    {
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }
    }
}
