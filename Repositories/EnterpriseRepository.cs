using BootCam.BootCam;
using BootCam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.Repositories
{
    public class EnterpriseRepository : IEnterpriseRepository
    {

        private readonly BootCampContextE _context;
        public EnterpriseRepository(BootCampContextE context)
        {
            _context = context;
        }
        public List<Enterprise> GetAllEnterprises()
        {
            return _context.Enterprise.ToList();
        }

        public List<Enterprise> GetAllEnterprisesCreaAsc()
        {
            return _context.Enterprise.ToList().OrderBy(enterprise => enterprise.Date).ToList();
        }

        public List<Enterprise> GetAllEnterprisesName()
        {
            return _context.Enterprise.ToList().OrderBy(enterprise => enterprise.Nom_Emp).ToList(); 
        }

        public List<Enterprise> GetAllEnterprisesVacantes()
        {
            return _context.Enterprise.OrderByDescending(enterprise => enterprise.Cant_Vacan).ToList();

        }

        public Enterprise SaveEnterprise(Enterprise enterprise)
        {
            _context.Enterprise.Add(enterprise);
            _context.SaveChanges();
            return enterprise;

        }
    }

}
