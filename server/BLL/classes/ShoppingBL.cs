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
    public class ShoppingBL : IShoppingBL
    {
        IShoppingDAL I;
        IMapper Imap;

        public ShoppingBL(IShoppingDAL i, IMapper imap)
        {
            this.I = i;
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<Myprofile>();
            }
            );
            Imap = config.CreateMapper();
        }


        public int SvaeShopping(ShoppingDTO s)
        {
           s.DateShopping = DateTime.Today;
            Shopping s1 = Imap.Map<ShoppingDTO, Shopping>(s);
           I.AddNew(s1);
            return s1.ShoppingId;

        }
        public List<ShoppingDTO> GetAll()
        {
            List<ShoppingDTO> l = Imap.Map<List<Shopping>, List<ShoppingDTO>>(I.GetAllShoppings());
         
            return l;
        }


    }
}
