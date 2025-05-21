using DAL.Models;
using DAL.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.classes
{
    public class GameDAL : IGameDAL
    {
        LEALE_VAINER_P_2025Context db=new();

        public bool AddGame(Game c)
        {
            try
            {
                db.Games.Add(c);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Game> GetGames()
        {
            return db.Games.ToList();
        }

        public bool RemoveGame(int id)
        {
            try
            {
                Game g = db.Games.FirstOrDefault(x => x.GameId == id);
                db.Games.Remove(g);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(int id, Game g)
        {
            try
            {
              
                db.Games.FirstOrDefault(x => x.GameId == id).Pecture = g.Pecture;
                db.Games.FirstOrDefault(x => x.GameId == id).ProductName = g.ProductName;
                db.Games.FirstOrDefault(x => x.GameId == id).Price = g.Price;
                db.Games.FirstOrDefault(x => x.GameId == id).CategorId = g.CategorId;
                db.Games.FirstOrDefault(x => x.GameId == id).Quantity = g.Quantity;
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
