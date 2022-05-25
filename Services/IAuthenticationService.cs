using BootCam.Models;
using BootCam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.Services
{
      
    public interface IAuthenticationService
    {

      
        bool Login(User user);

        User SaveUser(User user);

   
    }
    }
