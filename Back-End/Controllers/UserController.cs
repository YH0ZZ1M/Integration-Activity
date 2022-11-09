using Microsoft.AspNetCore.Mvc;
using BackEnd.Dtos;
using BackEnd.Models;
using BackEnd.Repositories;

namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController : ControllerBase
{
    private readonly IUserRepository repository;

    public UserController(IUserRepository repository)
    {
        this.repository = repository;
    }

    //READ ALL
    [HttpGet("Get All")]
    public async Task<ActionResult<RepositoryResponse<List<GetUserDto>>>> Get()
        {
            return Ok(await repository.GetAllUsers());
        }

    //CREATE
    //[HttpPost]
    //public ActionResult<UpdateUserDto> UpdateUser();
    

    //READ 
    [HttpGet("{id}")]
    public ActionResult<GetUserDto> GetUser(int id)
    {
        var user = repository.GetUser(id);

        if (user is null)
        {
            return NotFound();
        }
        return GetUser(id);
    }

    //UPDATE
    [HttpPut("{id}")]
    public ActionResult UpdatedUser(int id)
    {
        var registeredUser = repository.GetUser(id);

        if (registeredUser is null)
        {
            return NotFound();
        }

     //   User registereduser = registereduser with { Id = UserDto.Id, Name = UserDto.Name, Email = UserDto.Email };

     //   repository.UpdateUser(UpdatedUser);
        return NoContent();
    }

    //DELETE
    [HttpDelete("{id}")]

    public ActionResult DeleteUser(int id)
    {
        var registeredUser = repository.GetUser(id);

        if (registeredUser is null)
        {
            return NotFound();
        }

        repository.DeleteUser(id);

        return NoContent();
    }
}