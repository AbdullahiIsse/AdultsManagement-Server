using System;
using System.Threading.Tasks;
using AdultsWebApi.Data;
using AdultsWebApi.Models;
using Microsoft.AspNetCore.Mvc;


namespace AdultsWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController :ControllerBase
    {

        private IUserService UserService;


        public UserController(IUserService userService)
        {
            UserService = userService;
        }


        [HttpGet]
        public async Task<ActionResult<User>> GetUsers([FromQuery] string username, [FromQuery] string password)
        {
            try
            {
                User users = await UserService.ValidateUser(username,password);
                return Ok(users);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
              return  StatusCode(500, e.Message);
            }
            
        }


       
            
            
            
        }








    }
    

