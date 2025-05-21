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
    public class GameBL : IGameBL
    {
        IMapper Imap;
        IGameDAL I;

        public GameBL(IGameDAL i,IMapper Im)
        {
          
            this.I = i;
            var config=new MapperConfiguration(c =>
            {
                c.AddProfile<Myprofile>();
            }
            );
            Imap=config.CreateMapper();
        }

        public bool AddGame(GameDTO g)
        {
            Game ga = Imap.Map<GameDTO, Game>(g);
            return  I.AddGame(ga);
        }

        public bool DeleteGame(int id)
        {
            return I.RemoveGame(id);
        }

        public List<GameDTO> GetAllGames()
        {
            return Imap.Map<List<Game>,List<GameDTO>>(I.GetGames());
        }

        public List<GameDTO> GetGameByCategory(int id)
        {
            return Imap.Map<List<Game>, List<GameDTO>>(I.GetGames()).FindAll(x => x.CategorId == id);
        }

        public GameDTO GetGameById(int id)
        {
            return Imap.Map<List<Game>, List<GameDTO>>(I.GetGames()).FirstOrDefault(x => x.GameId == id);
        }

        public bool UpdateGame(int id, GameDTO g)
        {
            Game ga= Imap.Map<GameDTO, Game>(g);
            return I.Update(id, ga);
        }
    }
}
