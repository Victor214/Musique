using System;
using System.Collections.Generic;
using System.Text;

namespace Musique.Core
{
    public class User
    {
        public int Id { get; set; }

        public String Subject { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        // No need to store picture link, we can easily retrieve that later.
    }
}
