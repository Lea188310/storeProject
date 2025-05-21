using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.services
{
    public interface IShoppingDetailBL
    {
        public List<ShoppingDetailDTO> GetAll();
        public bool AddBug(int code, List<ShoppingCartDTO> sal);
    }
}
