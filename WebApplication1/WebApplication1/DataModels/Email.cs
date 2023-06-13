using System.Text.Json.Serialization;

namespace WebApplication1.DataModels
{
    public class Email
    {
        public int id { get; set; }
        public string email { get; set; }

        [JsonIgnore]
        public virtual Pessoa pessoa { get; set; }
    }
}
