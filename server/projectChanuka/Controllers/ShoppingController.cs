using BL.services;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projectChanuka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        IShoppingBL I;
        public ShoppingController(IShoppingBL i)
        {
            this.I = i;
        }
        [HttpGet("getAll")]
        public List<ShoppingDTO> getAll()
        {
            return I.GetAll();
        }
        

        [HttpPut("Add")]
        public int SaveShopping(ShoppingDTO s)
        {
            return I.SvaeShopping(s);
        }

    }
}
