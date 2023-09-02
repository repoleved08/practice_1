using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Event_MS.Responses;
using Event_MS.Requests;
using Event_MS.Models;

namespace Event_MS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public UserController(IUserService service, IMapper mapper)
        {
            _mapper = mapper;
            _userService = service;
        }

        [HttpPost]
        public async Task<ActionResult<UserSuccess>> AddUser(AddUser newUser)
        {
            var user = _mapper.Map<UserClass>(newUser);
            var res = await _userService.AddUserAsync(user);
            return CreatedAtAction(nameof(AddUser),new UserSuccess(201,res));
        }
    }
}
