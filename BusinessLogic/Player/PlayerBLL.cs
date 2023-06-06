using Entities.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Player
{
    public class PlayerBLL : IPlayerBll
    {
        #region Fields

        private readonly Context _context;

        #endregion

        #region Builder

        public PlayerBLL()
        {
            _context = new Context();
        }

        #endregion
        public void Delete(string nif)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.Entities.Player> Get()
        {
            var playerList = _context.Players.ToList();

            return playerList;
        }

        public Entities.Entities.Player Get(string nif)
        {
            var player = _context.Players.Where( p => p.NIF == nif ).ToList().FirstOrDefault();

            return player;
        }

        public void Post(Entities.Entities.Player value)
        {
            _context.Players.Add(value);

            _context.SaveChanges();
        }

        public void Put(int id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
