using Entities.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Game
{
    public class GameBLL : IGameBll
    {
        #region Fields

        private readonly Context _context;

        #endregion

        #region Builder

        public GameBLL()
        {
            _context = new Context();
        }

        #endregion

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.Entities.Game> Get()
        {
            var gameList = _context.Games.ToList();

            return gameList;
        }

        public Entities.Entities.Game Get(int id)
        {
            var user = _context.Games.Where(g => g.Id == id).ToList().FirstOrDefault();

            return user;
        }

        public void Post(Entities.Entities.Game value)
        {
            _context.Games.Add(value);

            _context.SaveChanges();
        }

        public void Put(int id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
