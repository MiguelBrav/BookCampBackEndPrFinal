using BootCam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.Repositories
{
    public interface IAuthenticationRepository
    {
        User GetUserbyemail(String email);

        User SaveUser(User user);

     
    }
}
