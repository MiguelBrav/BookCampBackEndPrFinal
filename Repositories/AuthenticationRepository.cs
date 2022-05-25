using BootCam.BootCam;
using BootCam.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BootCam.Repositories
{
    public class AuthenticationRepository : IAuthenticationRepository

   
    {
        private readonly BootCampContext _context;
        public AuthenticationRepository(BootCampContext context)
        {
            _context = context;
        }



        public User GetUserbyemail(String useremail)
        {


            return _context.User.Where(a => a.Email.Equals(useremail)).FirstOrDefault();
        }


        public User SaveUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChanges();
            return user;

        }

            
    }
}
