using Microsoft.AspNetCore.Mvc;
using BackEnd.Dtos.Users;
using BackEnd.Models;
using BackEnd.Repositories;

namespace BackEnd.Controllers;

[ApiController]
[Route("[controller]")]

public class UserController : ControllerBase
{
    public IUserRepository repository;
    public UserController(IUserRepository repository)
    {
        this.repository = repository;
    }

    #region Name
        
    #endregion
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

     //CREATE
    [HttpPost]
    public ActionResult<UpdateUserDto> UpdateUser()
    {
        throw new NotImplementedException();
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