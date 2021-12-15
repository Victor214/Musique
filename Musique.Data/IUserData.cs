using System;
using System.Collections.Generic;
using System.Text;
using Musique.Core;

namespace Musique.Data
{
    public interface IUserData
    {
        User GetUserBySubject(String subject); // Returns a user if there is one.
        User AddUser(User newUser); // Adds a new user onto the database.
        int GetCountOfUsers();
        int Commit();
    }
}
