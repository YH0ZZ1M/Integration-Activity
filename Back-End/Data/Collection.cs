using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;

namespace BackEnd.Data
{
    public class UserCollec
    {
        public List<User> collection { get; set; }
        public UserCollec()
        {
            collection = new List<User>();
        }

    }

    public class ItemCollec
    {
        public List<Inventory> collection { get; set; }
        public ItemCollec()
        {
            collection = new List<Inventory>();
        }

    }
}