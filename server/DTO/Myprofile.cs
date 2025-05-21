using AutoMapper;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class Myprofile:Profile
    {
        public Myprofile()
        {
            //category
            CreateMap<Category, CategoryDTO>();
            CreateMap< CategoryDTO,Category>();

            //game
            CreateMap<Game, GameDTO>();
            CreateMap< GameDTO, Game>();

            //custemer
            CreateMap<Custemer, CustemerDTO>();
            CreateMap<CustemerDTO,Custemer>();

            //shopping
            CreateMap<Shopping, ShoppingDTO>();
            CreateMap<ShoppingDTO, Shopping>();

            //shoppingDetail
            CreateMap<ShoppingDetail, ShoppingDetailDTO>();
            CreateMap<ShoppingDetailDTO, ShoppingDetail>();
         


        }


    }
}
