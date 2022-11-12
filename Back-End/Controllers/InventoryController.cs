using Microsoft.AspNetCore.Mvc;
using BackEnd.Dtos.Items;
using BackEnd.Models;
using BackEnd.Repositories;

namespace Net_Evaluation.Controllers;

[ApiController]
[Route("Inventory")]

public class InventoryController : ControllerBase
{
     public IInventoryRepository repository;
    public InventoryController(IInventoryRepository repository)
    {
        this.repository = repository;
    }

    //READ ALL
    [HttpGet("Get All")]
    public async Task<IEnumerable<GetItemDto>> GetAllItems()
        {
            var response = (await repository.GetAllItems()).Select(item => item.AsDto());
            return response;
        }

    //READ BY ID
    [HttpGet("{id}")]
    public ActionResult<GetItemDto> GetItem(int id)
    {
        var item = repository.GetItem(id);

        if (item is null)
        {
            return NotFound();
        }
        return GetItem(id);
    }

    //UPDATE
    [HttpPut("{id}")]
    public ActionResult<Inventory> UpdateItem(UpdateItemDto newItem)
    {
        return Ok(repository.UpdateItem(newItem));
    }

     //CREATE
    [HttpPost]
    public ActionResult<Inventory> CreateItem(CreateItemDto newItem)
    {
        return Ok(repository.CreateItem(newItem));
    }
    

    //DELETE
    [HttpDelete("{id}")]

    public ActionResult<Inventory> DeleteItem(int id)
    {
        return Ok(repository.DeleteItem(id));
    }
}