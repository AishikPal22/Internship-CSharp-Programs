using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace TicketManagement
{
    public class DBHandler  //DO NOT change the class name
    {
        //Implement the methods as per the description
        public DBHandler() { }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString);
        }
    }
}
