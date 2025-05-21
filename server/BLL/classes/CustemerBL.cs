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
    public class CustemerBL : ICustemerBL
    {
        ICustemerDAL I;
        IMapper IMap;
        public CustemerBL(ICustemerDAL ic)
        {
            I = ic;
            var config = new MapperConfiguration(cf =>
            {
                cf.AddProfile<Myprofile>();
            });
            IMap = config.CreateMapper();
        }

        //הוספה
        public bool Add(CustemerDTO c)
        {
            Custemer ca=IMap.Map<CustemerDTO,Custemer>(c);
           return I.AddCustemer(ca);
        }
        //שליפה
        public List<CustemerDTO> GetCustemers()
        {
            return IMap.Map<List<Custemer>, List<CustemerDTO>>(I.GetCustemers());
        }
        //בדיקה אם קיים
        public bool IsExsist(string pass, string name)
        {
            List<Custemer> AllCustemers = I.GetCustemers(); 
            Custemer a= AllCustemers.FirstOrDefault(x=>x.CustPassword==pass && x.CustName==name);
            if (a == null)
                return false;
            return true;
        }
    }
}
