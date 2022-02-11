using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Williams_CRUD
{
    class db
    {
        public static string getConnString()
        {
            string connString = ConfigurationManager.AppSettings["connString"].ToString();
            return connString;
        }
    }
}
