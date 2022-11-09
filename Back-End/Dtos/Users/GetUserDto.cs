using BackEnd.Models;

namespace BackEnd.Dtos.Users

{
    public class GetUserDto
    {
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;
        public TypeUser UserType {get; set;}
        public string Email {get;set;} = string.Empty;
        public double Phone {get;set;} 
        public List<Inventory>? Items { get; set; }

        public GetUserDto(User u)
        {
            Id = u.Id;
            Name = u.Name;
            UserType = u.UserType;
            Email = u.Email;
            Phone = u.Phone;
            List<Inventory> Items = new();
        }
    } 
}