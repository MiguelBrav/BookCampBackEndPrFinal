using BootCam.Models;
using BootCam.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BootCam.Services
{
    public class EnterpriseService : IEnterpriseService
    {
        private IEnterpriseRepository _enterpriseRepository;
        public EnterpriseService(IEnterpriseRepository ientnRepository)
        {
            _enterpriseRepository = ientnRepository;

        }
        public List<Enterprise> GetAllEnterprises()
        {
            return _enterpriseRepository.GetAllEnterprises();
        }

        public List<Enterprise> GetAllEnterprisesCreaAsc()
        {
            return _enterpriseRepository.GetAllEnterprisesCreaAsc();
        }

        public List<Enterprise> GetAllEnterprisesName()
        {
            return _enterpriseRepository.GetAllEnterprisesName();
        }

        public List<Enterprise> GetAllEnterprisesVacantes()
        {
            return _enterpriseRepository.GetAllEnterprisesVacantes();
        }

        public Enterprise SaveEnterprise(Enterprise enterprise)
        {
            enterprise.Cant_Vacan = GetTotalVacantsOCC(enterprise.Nom_Emp);
            return _enterpriseRepository.SaveEnterprise(enterprise);
        }
        private int GetTotalVacantsOCC(String nombre)
        {
            //to Do: implementar web scraping
            return 1;
        }
    }
}    