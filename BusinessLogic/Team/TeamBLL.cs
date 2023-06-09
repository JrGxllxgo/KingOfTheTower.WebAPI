using Entities.AppContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Team
{
    public class TeamBLL : ITeamBll
    {
        #region Fields

        private readonly Context _context;

        #endregion

        #region Builder

        public TeamBLL()
        {
            _context = new Context();
        }

        #endregion

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.Entities.Team> Get()
        {
            var teamList = _context.Teams.ToList();

            return teamList;
        }

        public Entities.Entities.Team Get(string name)
        {
            var team = _context.Teams.Where(t => t.Name == name).FirstOrDefault();

            return team;
        }

        public IEnumerable<Entities.Entities.Team> GetByGroup(string groupName)
        {
            var teams = _context.Teams.Where(g => g.Group.Name == groupName).AsNoTracking();

            return teams;
        }

        public void Post(Entities.Entities.Team value)
        {
            var context = new Context();

            context.Teams.Add(value);
            
            context.SaveChanges();
        }

        public void Put(int id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
