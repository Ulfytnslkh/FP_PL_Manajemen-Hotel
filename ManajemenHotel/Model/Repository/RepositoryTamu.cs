using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using ManajemenHotel.Model.Entity;
using ManajemenHotel.Model.Context;
using System.Security.Permissions;

namespace ManajemenHotel.Model.Repository
{
    public class RepositoryTamu
    {
        private SQLiteConnection _conn;

        public RepositoryTamu(DbContext context)
        {
            _conn = context.Conn;
        }

        
    }
}
