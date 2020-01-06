using Microsoft.AspNetCore.Mvc;

namespace FoodKhoj_BackEnd.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LoginController : ControllerBase
    {
        //private IFoodKhojContext _dbContext;

        //public LoginController(IFoodKhojContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        [Route("loginuser")]
        [HttpGet]
        public IActionResult LoginUser()
        {
            return Ok();
        }

        //[Route("registeruser")]
        //[HttpPost]
        //public IActionResult RegisterUser(User model)
        //{
        //    IActionResult response = Unauthorized();
        //    var data = _dbContext.Insert_User(model);
        //    response = Ok(new { data });

        //    return response;
        //}
    }
}