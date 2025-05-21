using AutoMapper;
using BL.services;
using DAL.Models;
using DAL.services;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.classes
{
    public class CategoryBL : ICategoryBL
    {
        IMapper Imap;
        ICategoryDAL Ic;

        public CategoryBL(ICategoryDAL ic)
        {
            Ic = ic;
            var config = new MapperConfiguration(cf =>
            {
                cf.AddProfile<Myprofile>();
            });
            Imap = config.CreateMapper();

        }

        public bool AddCAtegory(CategoryDTO c)
        {
            Category ca = Imap.Map<CategoryDTO, Category>(c);
           return Ic.AddCategory(ca);
        }

        public bool Delete(int id)
        {
             return  Ic.RemoveCategory(id);
        }

        public List<CategoryDTO> GetAllCategories()
        {
            return Imap.Map<List<Category>,List<CategoryDTO>>( Ic.GetCategories());
        }

        public CategoryDTO GetCategoryByID(int id)
        {
            return Imap.Map<List<Category>, List<CategoryDTO>>(Ic.GetCategories()).FirstOrDefault(x => x.CategorId == id);
        }

        public bool Update(int id, CategoryDTO c)
        {
            Category ca = Imap.Map<CategoryDTO, Category>(c);
            return Ic.Update(id, ca);
        }
    }
}
