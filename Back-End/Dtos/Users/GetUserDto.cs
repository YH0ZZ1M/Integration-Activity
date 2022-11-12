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
    } 
}