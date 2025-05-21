using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.services
{
    public interface ICustemerBL
    {
        public List<CustemerDTO> GetCustemers();
        public bool Add(CustemerDTO c);
        public bool IsExsist(string pass,string name);
    }
}
