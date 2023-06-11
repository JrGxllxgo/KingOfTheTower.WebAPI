using Azure.Core;
using Entities.AppContext;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
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

        public Entities.Entities.Player Post(Entities.Entities.Player value)
        {
            try
            {
                if (string.IsNullOrEmpty(value.NIF))
                    throw new Exception("El DNI del jugador no puede ser nulo/vacio:");

                if (!Regex.IsMatch(value.NIF, @"^[XYZ]?\d{7,8}[A-Z]$"))
                    throw new Exception("El formato del DNI no es correcto.");

                // Guardamos el jugador:
                var result = _context.Players.Add(value);             
                _context.SaveChanges();

                return result.Entity;
            }
            catch (Exception ex)
            {
                var m = ex.Message;
                throw;
            }           
        }

        public void Put(int id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
