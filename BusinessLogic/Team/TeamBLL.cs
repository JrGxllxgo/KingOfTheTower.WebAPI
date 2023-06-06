using Entities.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Team
{
    public class TeamBLL : ITeamBll
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> Get()
        {
            throw new NotImplementedException();
        }

        public string Get(int id)
        {
            throw new NotImplementedException();
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
