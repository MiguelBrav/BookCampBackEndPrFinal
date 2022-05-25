
using BootCam.BootCam;
using BootCam.Models;
using BootCam.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.Controllers
{
    [EnableCors("Bootcamp")]
    [Route("api/[controller]")]
    [ApiController]
    public class ControllerAuth : ControllerBase
    {


        private IAuthenticationService _authservice;

        public ControllerAuth(IAuthenticationService authservice)
        {
            _authservice = authservice;
        }




        [HttpPost]
        [Route("login")]
        public ActionResult<bool> LoginUser1(User user)
        {
           if(_authservice.Login(user) == true)
            {
                //enviar dashboard
                return true;
            }
           //no enviar
            return false;
           
        }



        /*
              [HttpPost]
              [Route("login")]
              public ActionResult Login(User user)
              {


                      using (_context)
                      {
                          var obj = _context.User.Where(a => a.Email.Equals(user.Email) && a.Pass.Equals(user.Pass)).FirstOrDefault();
                          if (obj != null)
                          {
                              user.Email = obj.Email.ToString();
                              user.Pass = obj.Pass.ToString();
                              return StatusCode(StatusCodes.Status200OK,"Accede");
                          }
                  return StatusCode(StatusCodes.Status400BadRequest, "Error");
              }


              }     */
        /*
              [HttpPost]
              [Route("login")]
              public ActionResult<bool> Login([FromBody] User user)
              {

                  try
                  {

                 return StatusCode(StatusCodes.Status200OK, _authservice.Login(user));

                  }
                  catch (Exception ex)
                  {
                      throw new Exception(ex.Message);
                  }
              }

           */


    }
}

