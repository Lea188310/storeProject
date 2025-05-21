using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.services
{
    public interface IGameDAL
    {
        public List<Game> GetGames();
        public bool AddGame(Game c);
        public bool RemoveGame(int id);
        public bool Update(int id, Game g);

    }
}
