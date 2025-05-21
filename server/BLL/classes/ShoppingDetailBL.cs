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
    public class ShoppingDetailBL:IShoppingDetailBL
    {
        IMapper Imap;
        IShoppingDetailDAL I;
       
        public ShoppingDetailBL(IShoppingDetailDAL i)
        {
            this.I = i;
            var config = new MapperConfiguration(c =>
            {
                c.AddProfile<Myprofile>();
            }
            );
            Imap = config.CreateMapper();
        }



        public bool AddBug(int code, List<ShoppingCartDTO> sal)
        {
            try
            {
                foreach (ShoppingCartDTO c in sal)
                {
                    ShoppingDetail s = new();
                    s.ShoppingId = code;
                    s.Quantity = c.Amount;
                    s.GameId = c.Id;

                    I.Add(s);
                }
                
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<ShoppingDetailDTO> GetAll()
        {
            return Imap.Map<List<ShoppingDetail>, List<ShoppingDetailDTO>>(I.GetAll());
        }
    }
}
