using System.Text.Json.Serialization;

namespace BackEnd.Models

{
    [JsonConverter (typeof(JsonStringEnumConverter))]
    public enum TypeUser
    {
        Regular,
        VIP,
        New
    }
}