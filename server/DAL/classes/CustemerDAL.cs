using DAL.Models;
using DAL.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.classes
{
    public class CustemerDAL : ICustemerDAL
    {
        LEALE_VAINER_P_2025Context db = new();
        public bool AddCustemer(Custemer c)
        {
            try
            {
                db.Add(c);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Custemer> GetCustemers()
        {
            return db.Custemers.ToList();
        }

        public bool RemoveCustemer(int id)
        {
            try
            {
                Custemer c = db.Custemers.FirstOrDefault(x => x.CustemerId == id);
                db.Custemers.Remove(c);
                db.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustemer(int id, Custemer c)
        {
            try
            {
                db.Custemers.FirstOrDefault(x => x.CustemerId == id).CustName = c.CustName;
                db.Custemers.FirstOrDefault(x => x.CustemerId == id).CustPassword = c.CustPassword;
                db.Custemers.FirstOrDefault(x => x.CustemerId == id).CreditDetails = c.CreditDetails;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
