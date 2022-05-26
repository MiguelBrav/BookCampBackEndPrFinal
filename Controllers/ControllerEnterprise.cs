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
    public class ControllerEnterprise : ControllerBase

    {

        private IEnterpriseService _enterpriseservice;

        public ControllerEnterprise(IEnterpriseService enterpriseService)
        {
            _enterpriseservice = enterpriseService;
        }
        [HttpPost]
        [Route("saveEnterprise")]
        public ActionResult<bool> SaveEnterprise([FromBody] Enterprise enterprise)
        {
            try
            {
               // enterprise.Date = DateTime.Now;
                return StatusCode(StatusCodes.Status200OK, _enterpriseservice.SaveEnterprise(enterprise));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //apiBase/controlador/endpoint
        [HttpGet]
        [Route("all")]
        public ActionResult<List<Enterprise>> GetAllEnterprises()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprises());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }



        [HttpGet]
        [Route("all/OrderType/1")]
        public ActionResult<List<Enterprise>> GetAllEnterprisenombres()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesName());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("all/OrderType/2")]
        public ActionResult<List<Enterprise>> GetAllEnterprisevacantes()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesVacantes());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("all/OrderType/3")]
        public ActionResult<List<Enterprise>> GetAllEnterprisecreacionAscendente()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesCreaAsc());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpGet]
        [Route("all/OrderType/4")]
        public ActionResult<List<Enterprise>> GetAllEnterprisecreacionDescendente()
        {
            try
            {
                return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesCreaDes());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
