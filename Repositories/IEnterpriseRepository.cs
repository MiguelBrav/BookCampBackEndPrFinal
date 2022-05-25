using BootCam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.Repositories
{
    public interface IEnterpriseRepository
    {

        Enterprise SaveEnterprise(Enterprise enterprise);

        List<Enterprise> GetAllEnterprises();

        List<Enterprise> GetAllEnterprisesName();

        List<Enterprise> GetAllEnterprisesVacantes();

        List<Enterprise> GetAllEnterprisesCreaAsc();

    }
}
