using BL.services;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projectChanuka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingDetailController : ControllerBase
    {
        IShoppingDetailBL I;

        public ShoppingDetailController(IShoppingDetailBL i)
        {
            this.I = i;
        }
        [HttpPut("add")]
        public bool AddBug(int code, List<ShoppingCartDTO> sal)
        {
            return I.AddBug(code, sal);
        }
        [HttpGet("GetAll")]
        public List<ShoppingDetailDTO> GetAll()
        {
            return I.GetAll();
        }
    }
}
