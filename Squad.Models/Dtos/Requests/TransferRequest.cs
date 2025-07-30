using System.Text.Json.Serialization;

namespace Squad.Models.Dtos.Requests
{
    public class TransferRequest
    {
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
        [JsonPropertyName("bank_code")]
        public string BankCode { get; set; }
        [JsonPropertyName("currency_id")]
        public string CurrencyId { get; set; }
        [JsonPropertyName("amount")]
        public string Amount { get; set; }
        [JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }
        [JsonPropertyName("transaction_reference")]
        public string TransactionReference { get; set; }
        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

//C# has a naming convention which I am following, but the json objects need to tally with HabariPay's payload. That's what the JsonPropertyName is for






    }
}
