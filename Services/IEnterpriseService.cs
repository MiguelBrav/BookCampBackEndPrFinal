using BootCam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.Services
{
    public interface IEnterpriseService
    {
        bool SaveEnterprise(Enterprise enterprise);

        List<Enterprise> GetAllEnterprises();

        List<Enterprise> GetAllEnterprisesName();

        List<Enterprise> GetAllEnterprisesVacantes();

        List<Enterprise> GetAllEnterprisesCreaAsc();

        List<Enterprise> GetAllEnterprisesCreaDes();
    }
}
