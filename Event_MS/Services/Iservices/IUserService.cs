using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event_MS.Models;
using Event_MS.Requests;


public interface IUserService
{
    Task<string> AddUserAsync(UserClass user);
    //update
    Task<string> UpdateUserAsync(UserClass user);
    //delete
    Task<string> DeleteUserAsync(UserClass user);

    //Get All User
    Task<IEnumerable<UserClass>> GetAllUsersAsync();
    Task<UserClass> GetUserByIdAsync(Guid id);
    Task<string> AddUserAsync(AddUser user);
}

