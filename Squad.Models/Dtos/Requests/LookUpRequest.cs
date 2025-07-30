using System.Text.Json.Serialization;

namespace Squad.Models.Dtos.Requests
{
    public class LookUpRequest
    {
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }


    }
}
