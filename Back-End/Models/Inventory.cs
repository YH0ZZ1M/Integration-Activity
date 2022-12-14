using BackEnd.Dtos.Items;

namespace BackEnd.Models
{
public class Inventory
    {
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;
        public string Description {get;set;} = string.Empty;
        public int Quantity {get;set;} 
        public int UserId{get;set;}
        public User? Owner {get;set;}

         public GetItemDto AsDto()
        {
            return new GetItemDto(){
            Id = this.Id,
            Name = this.Name,
            Description = this.Description,
            Quantity = this.Quantity,
            UserId = this.UserId,
            };
        }

    }
 
}