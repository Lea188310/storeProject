using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.services
{
    public interface IGameBL
    {
      
        public List<GameDTO> GetAllGames(); 
        public GameDTO GetGameById(int id);
        public bool AddGame(GameDTO g); 
        public bool UpdateGame(int id,GameDTO g);
        public bool DeleteGame(int id);
        public List<GameDTO> GetGameByCategory(int id);

    }
}
