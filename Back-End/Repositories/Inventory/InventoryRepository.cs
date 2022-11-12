using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BackEnd.Models;
using BackEnd.Dtos.Items;
using BackEnd.Data;
using Microsoft.AspNetCore.Mvc;

namespace BackEnd.Repositories
{
    public class InventoryRepository : IInventoryRepository
    {
        public ItemCollec _coll {get;}

        public InventoryRepository(ItemCollec collection)
        {
            this._coll = collection;
        }

        public DataContext _context {get;}

        public InventoryRepository(DataContext context)
        {
            this._context = context;
        }

        //GET INVENTORY
        
        public async Task<IEnumerable<Inventory>>GetAllItems()
        {
            return await _context.Items.ToListAsync();            
        }

        //GET ITEM
        public async Task<GetItemDto> GetItem(int id)
        {
            var response = await _context.Items.FirstOrDefaultAsync(i => i.Id == id);
            if (response is null)
            {
                throw new NullReferenceException($"Inventory with ID {id} not found");
            }
            return response.AsDto();
        }

        //CREATE NEW ITEM
        public Inventory CreateItem(CreateItemDto newItem)
        {
            Inventory ne = new Inventory(){
                Id = _coll.collection.Count +1,
                Name = newItem.Name,
                Description = newItem.Description,
                Quantity = newItem.Quantity,
                UserId = newItem.UserId,
            };
            _coll.collection.Add(ne);
            return ne;
        }

        //DELETE USER
        public Inventory DeleteItem(int id)
        {
            Inventory ol = _coll.collection.Find(i => i.Id ==id);
             if (ol is null)
            {
                throw new NullReferenceException($"Inventory not found");
            }
            _coll.collection.Remove(ol);
            return ol;
        }

        //UPDATE USER
        public Inventory UpdateItem(UpdateItemDto newItem)
        {
            Inventory up = _coll.collection.Find(i => i.Id == newItem.Id);
            if (up != null)
            {
                int ind = _coll.collection.IndexOf(up);
                Inventory ne = new Inventory(){
                    Id = _coll.collection.Count +1,
                    Name = newItem.Name,
                    Description = newItem.Description,
                    Quantity = newItem.Quantity,
                    UserId = newItem.UserId,
                };
                _coll.collection[ind] = ne;
                return _coll.collection[ind];
            } 
                else{
                    return new Inventory();
                }
        }
    }
}

















          
