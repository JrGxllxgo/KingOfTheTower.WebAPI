﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Team
{
    public interface ITeamBll
    {
        IEnumerable<Entities.Entities.Team> Get();
        Entities.Entities.Team Get(string name);
        void Post(Entities.Entities.Team value);
        void Put(int id, string value);
        void Delete(int id);
    }
}
