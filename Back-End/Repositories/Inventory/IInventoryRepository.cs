using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BackEnd.Models;
using BackEnd.Dtos.Items;

namespace BackEnd.Repositories
{
    public interface IInventoryRepository
    {
        Task<GetItemDto> GetItem(int id);
        Task<IEnumerable<Inventory>> GetAllItems();
        Inventory DeleteItem(int id);
        Inventory UpdateItem(UpdateItemDto newItem);
        Inventory CreateItem(CreateItemDto newItem);

    }
}