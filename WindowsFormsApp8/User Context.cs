using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class User_Context: DbContext
    {
        public User_Context() : base("DbConnection") { }
        public DbSet<User> Users { get; set; }

    }
}
