
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")] // bu isteği yaparken nasıl ulaşacağımızın bilgisini verir.
    [ApiController] //attribute -> bir class ile ilgili bilgi verme (imzalama) yöntemidir.
    public class UsersController : ControllerBase
    {
        //Loose coupling(gevşek bağlılık) -> bir bağımlılık var ama soyuta bağımlılık var
        //naming convention (isimlendirme standardı)
        //IoC Container -> Inversion of control (değişimin kontrolü)
        
        IUserService _userService;
        
        // UserController in bir IUserService bağımlısı olduğunu ifade eder
        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //SWAGGER -> API DÖKÜMANTASYON 
            //dependency chain (bağımlılık zinciri)

            var result = _userService.GetAll();
            if (result.Success)
            {
                return Ok(result); //200 - > başarılı oldu
            }
            return BadRequest(result); //400
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _userService.UserById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("postadd")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("postdelete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("postupdate")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

 
    }
}
