using Event_MS.Data;

using Event_MS.Models;
using Event_MS.Requests;


public class UserService : IUserService
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<string> AddUserAsync(UserClass user)
        {
            _context.userClasses.Add(user);
            await _context.SaveChangesAsync();
            return "User Created Successfully";
        }

    public Task<string> AddUserAsync(AddUser user)
    {
        throw new NotImplementedException();
    }

    public Task<string> DeleteUserAsync(UserClass user)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<UserClass>> GetAllUsersAsync()
    {
        throw new NotImplementedException();
    }

    public Task<UserClass> GetUserByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<string> UpdateUserAsync(UserClass user)
    {
        throw new NotImplementedException();
    }
}

