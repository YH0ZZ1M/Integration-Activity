using BackEnd.Dtos.Users;

namespace BackEnd.Models
{
    public class User
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public TypeUser UserType { get; set; }
        public string Email { get; set; } = string.Empty;
        public double Phone { get; set; }
        //public List<Inventory>? Items { get; set; }

         public GetUserDto AsDto()
        {
            return new GetUserDto(){
            Id = this.Id,
            Name = this.Name,
            UserType = this.UserType,
            Email = this.Email,
            Phone = this.Phone,
            };
        }
    }
}