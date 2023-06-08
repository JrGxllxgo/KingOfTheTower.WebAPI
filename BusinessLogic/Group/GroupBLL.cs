using Entities.AppContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Group
{
    public class GroupBLL : IGroupBll
    {

        #region Fields

        private readonly Context _context;

        #endregion

        #region Builder

        public GroupBLL()
        {
            _context = new Context();
        }

        #endregion

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.Entities.Group> Get()
        {
            var groups = _context.Groups.ToList();
        
            return groups;
        }

        public Entities.Entities.Group Get(string name)
        {
            var groupSelected = _context.Groups.Where(g => g.Name == name).ToList().FirstOrDefault();

            return groupSelected;
        }

        public void Post(Entities.Entities.Group value)
        {
            _context.Groups.Add(value);

            _context.SaveChanges();
        }

        public void Put(int id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
