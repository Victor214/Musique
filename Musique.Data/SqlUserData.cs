using Musique.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Musique.Data
{
    public class SqlUserData : IUserData
    {
        private MusiqueDbContext db;

        public SqlUserData(MusiqueDbContext db)
        {
            this.db = db;
        }

        public User AddUser(User newUser)
        {
            db.Users.Add(newUser);
            return newUser;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public int GetCountOfUsers()
        {
            return db.Users.Count();
        }

        public User GetUserBySubject(String subject)
        {
            var query = from u in db.Users
                        where u.Subject == subject
                        select u;
            return query.FirstOrDefault();
        }
    }
}
