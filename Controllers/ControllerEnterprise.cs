using BootCam.Models;
using BootCam.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

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
                enterprise.Date = DateTime.Now;
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
        [Route("all/OrderType/{id}")]
        public ActionResult<List<Enterprise>> GetAllEnterprisenombres(int id)
        {

            switch (id)
            {
                case 1:
                    try
                    {
                        return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesName());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }
                    
              
                 
                case 2:
                    try
                    {
                        return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesVacantes());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }


                case 3:

                    try
                    {
                        return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesCreaAsc());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }


                case 4:
                    try
                    {
                        return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesCreaDes());
                    }
                    catch (Exception ex)
                    {
                        throw new Exception(ex.Message);
                    }


                default:
                    //      return StatusCode(StatusCodes.Status400BadRequest);
                    {
                        throw new ApplicationException("Ingresa un numero de ordenamiento válido");
                    }

            }


        }
     
            /*
            if (id == 1)
            {
                return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesName());
            } 
            if (id == 2)
            {
                return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesVacantes());
            }
            if (id == 3)
            {
                return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesCreaAsc());
            }
            if (id == 4)
            {
                return StatusCode(StatusCodes.Status200OK, _enterpriseservice.GetAllEnterprisesCreaDes());
            } 
            return StatusCode(StatusCodes.Status400BadRequest);
            */
  
        /*
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
        }*/
        /*
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
        }*/
        /*
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
        */

    }
}
