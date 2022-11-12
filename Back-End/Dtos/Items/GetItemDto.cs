using BackEnd.Models;

namespace BackEnd.Dtos.Items

{
    public record GetItemDto
    {
        public int Id {get;init;}
        public string Name {get;init;} = string.Empty;
        public string Description {get;init;} = string.Empty;
        public int Quantity {get;init;} 
        public int UserId{get;init;}
    } 
}