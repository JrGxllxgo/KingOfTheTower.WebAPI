using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Game
{
    public interface IGameBll
    {
        IEnumerable<Entities.Entities.Game> Get();
        Entities.Entities.Game Get(int id);
        void Post(Entities.Entities.Game value);
        void Put(int id, string value);
        void Delete(int id);
    }
}
