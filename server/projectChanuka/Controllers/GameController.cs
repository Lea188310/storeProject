using BL.services;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace projectChanuka.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        IGameBL I;
        public GameController(IGameBL i)
        {
            this.I = i;
        }


        [HttpGet("GetAll")]
        public List<GameDTO> GetAll()
        {
            return I.GetAllGames();
        }
        [HttpGet("GetByGameID/{id}")]
        public GameDTO GetByID(int id)
        {
            return I.GetGameById(id);   
        }
        [HttpGet("GetGategoryByid/{id}")]
        public List<GameDTO>  GetGameByCategory(int id)
        {
            return I.GetGameByCategory(id);
        }
        [HttpDelete("Dell/{id}")]
        public bool Dell(int id)
        {
            return I.DeleteGame(id);
        }
        [HttpPut("Add")]
        public bool Add(GameDTO g)
        {
            return I.AddGame(g);
        }
        [HttpPost("UpdateGame/{id}")]
        public bool UpdateGame(int id,GameDTO g)
        {
            return I.UpdateGame(id,g);    
        }
    }
}
