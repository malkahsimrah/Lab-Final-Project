using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Final_Project.DL
{
    public class DBConnection
    {
        private SqlConnection sqlCon;
        public DBConnection()
        {

            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, 
                                StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);
            string conString = 
                @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="
                + appPath[0] + 
                @"GradingSystem.mdf;Integrated Security=True";

            SqlCon = new SqlConnection(conString);
        }

        public SqlConnection SqlCon { get => sqlCon; set => sqlCon = value; }
    }
}
