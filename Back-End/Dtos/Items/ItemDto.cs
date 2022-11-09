using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;

namespace BackEnd.Dtos
{
    public class ItemDto
    {
        public int Id {get;set;}
        public string Name {get;set;} = string.Empty;
        public string Description {get;set;} = string.Empty;
        public int Quantity {get;set;} 
        public int UserId{get;set;}
        public User? Owner {get;set;}
    }
}