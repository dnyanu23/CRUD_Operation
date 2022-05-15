using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Operation.Utility
{
    public static class ConnectionString
    {
        private static string cName = "Data Source=DESKTOP-PCVQLL6\\MSSQLSERVER02; Initial Catalog=StudentManagement;Trusted_Connection=True;";
        public static string CName
        {
            get => cName;
        }
    }
}
