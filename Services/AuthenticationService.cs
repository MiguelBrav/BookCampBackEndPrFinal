using BootCam.Models;
using BootCam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private IAuthenticationRepository _authRepository;
        public AuthenticationService(IAuthenticationRepository iAuthenticationRepository)
        {
            _authRepository = iAuthenticationRepository;

        }



        public bool Login(User user)
        {
            User currentuser = _authRepository.GetUserbyemail(user.Email);

            if (currentuser == null)
            {
                return false;
            }

            if (currentuser.Email == "" || currentuser.Pass == "")
            {
                return false;
            }
            if (currentuser.Email != user.Email || currentuser.Pass != user.Pass)
            {
                return false;
            }
            if (currentuser.Email == user.Email && currentuser.Pass == user.Pass)
            {
                return true;
            }
            return false;
            //  return _authRepository.Login(user);
        }

    

        public User SaveUser(User user)
        {
            return _authRepository.SaveUser(user);
        }
    }

   
    
}
