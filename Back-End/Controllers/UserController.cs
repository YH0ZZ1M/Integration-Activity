using Microsoft.AspNetCore.Mvc;
using BackEnd.Dtos.Users;
using BackEnd.Models;
using BackEnd.Repositories;

namespace BackEnd.Controllers;

[ApiController]
[Route("Users")]

public class UserController : ControllerBase
{
    public IUserRepository repository;
    public UserController(IUserRepository repository)
    {
        this.repository = repository;
    }

    //READ ALL
    [HttpGet("Get All")]
    public async Task<IEnumerable<GetUserDto>> GetAllUsers()
        {
            var response = (await repository.GetAllUsers()).Select(user => user.AsDto());
            return response;
        }

    //READ BY ID
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
    public ActionResult<User> UpdateUser(UpdateUserDto newUser)
    {
        return Ok(repository.UpdateUser(newUser));
    }

     //CREATE
    [HttpPost]
    public ActionResult<User> CreateUser(CreateUserDto newUser)
    {
        return Ok(repository.CreateUser(newUser));
    }
    

    //DELETE
    [HttpDelete("{id}")]

    public ActionResult<User> DeleteUser(int id)
    {
        return Ok(repository.DeleteUser(id));
    }
}