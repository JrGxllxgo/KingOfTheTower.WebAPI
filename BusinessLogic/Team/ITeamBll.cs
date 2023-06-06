using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Team
{
    public interface ITeamBll
    {
        IEnumerable<string> Get();
        string Get(int id);
        void Post(Entities.Entities.Team value);
        void Put(int id, string value);
        void Delete(int id);
    }
}
