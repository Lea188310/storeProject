using BL.services;
using DAL.Models;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projectChanuka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryBL I;

        public CategoryController(ICategoryBL i)
        {
            this.I = i;
        }
        [HttpGet("GetAll")]
        public List<CategoryDTO> GetAll()
        {
            return I.GetAllCategories();
        }

        [HttpPut("Add")]
        public bool AddCategory(CategoryDTO c)
        {
            return I.AddCAtegory(c);
        }
      
        [HttpDelete("Dell/{id}")]
        public bool DellCategory(int id)
        {
            return I.Delete(id);
        }

        [HttpPost("UpdateCategory")]
        public bool UpdateCategory(int id,CategoryDTO c)
        {
            return I.Update(id,c);
        }
        [HttpGet("GetByID/{id}")]
        public CategoryDTO GeByID(int id)
        {
            return I.GetCategoryByID(id);
        }
    }
}
