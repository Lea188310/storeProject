using BL.services;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projectChanuka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustemerController : ControllerBase
    {
        ICustemerBL I;
        public CustemerController(ICustemerBL i)
        {
            this.I = i;
        }

        [HttpGet("GetAll")]
        public List<CustemerDTO> GetAll()
        {
            return I.GetCustemers();
        }
        [HttpPut("Add")]
        public bool Add(CustemerDTO c)
        {
            return I.Add(c);
        }
        [HttpGet("ifExist/{pass}/{name}")]
        public bool IfExsist(string pass,string name)
        {
            return I.IsExsist(pass,name);
        }
    }
}
