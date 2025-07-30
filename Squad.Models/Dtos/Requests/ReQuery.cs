using System.Text.Json.Serialization;

namespace Squad.Models.Dtos.Requests
{
    public class ReQueryRequest
    {
        [JsonPropertyName("transaction_reference")]
        public string TransactionReference { get; set; }


    }
}
