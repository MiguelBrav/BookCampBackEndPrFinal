using BootCam.Models;
using BootCam.Repositories;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

        public List<Enterprise> GetAllEnterprisesCreaDes()
        {
            return _enterpriseRepository.GetAllEnterprisesCreaDes();
        }

        public List<Enterprise> GetAllEnterprisesName()
        {
            return _enterpriseRepository.GetAllEnterprisesName();
        }

        public List<Enterprise> GetAllEnterprisesVacantes()
        {
            return _enterpriseRepository.GetAllEnterprisesVacantes();
        }

        public bool SaveEnterprise(Enterprise enterprise)
        {
           // var regex = new Regex(@"[^a-zA-Z0\s]");

            if (enterprise.Nom_Emp == "")
            {
                return false;
            } else
            {
            int numvacan = GetTotalVacantsOCC(enterprise.Nom_Emp);

            enterprise.Cant_Vacan = numvacan;

            _enterpriseRepository.SaveEnterprise(enterprise);
            return true;
            }

          

            //     if (regex.IsMatch(enterprise.Nom_Emp))
            // {


            //}
            // return false;

        }

        private static int GetTotalVacantsOCC(String Cant_Vacan)
        {
            _ = new HtmlDocument();
            HtmlWeb web = new();
            int vacantes;
            string inputTextDash = Cant_Vacan;

            string url = ($"https://www.occ.com.mx/empleos/de-{inputTextDash}");
            HtmlDocument doc = web.Load(url);

            var resVacOcc = doc.DocumentNode.SelectSingleNode("//*[text()[contains(., 'Empleos encontrados')]]").FirstChild.InnerText;

            vacantes = int.Parse(resVacOcc);

            return vacantes;
        }
    }
}    