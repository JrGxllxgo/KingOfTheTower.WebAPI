using Entities.AppContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.User
{
    public class UserBLL : IUserBll
    {
        #region Fileds

        private readonly Context _context;

        #endregion

        #region Builder

        public UserBLL()
        {
            _context = new Context();
        }

        #endregion

        public void Delete(string mail)
        {
            var userSelected = _context.Users.Where(u => u.Mail == mail).ToList().FirstOrDefault();

            //_context.Users.ExecuteDelete(userSelected);

            _context.SaveChanges();
        }

        public IEnumerable<Entities.Entities.User> Get()
        {
            var userList = _context.Users.ToList();

            return userList;
        }

        public Entities.Entities.User Get(string mail)
        {
            var user = _context.Users.Where(u => u.Mail == mail).ToList().FirstOrDefault();

            return user;
        }

        public void Post(Entities.Entities.User value)
        {
            _context.Users.Add(value);
            
            _context.SaveChanges();
        }

        public void Put(int id, string value)
        {
            throw new NotImplementedException();
        }
    }
}
