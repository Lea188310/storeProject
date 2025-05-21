using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.services
{
    public interface ICustemerDAL
    {
        public List<Custemer> GetCustemers();
        public bool AddCustemer(Custemer c);
        public bool RemoveCustemer(int id);
        public bool UpdateCustemer(int id, Custemer c);
    }
}
