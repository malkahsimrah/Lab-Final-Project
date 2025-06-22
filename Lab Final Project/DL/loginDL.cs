using Lab_Final_Project.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Lab_Final_Project.DL
{
    public class loginDL
    {
        DBConnection myConnection;
        public loginDL()
        {
            myConnection = new DBConnection();
        }
        public loginDTO verifyUserFromDB(loginDTO login)
        {
            loginDTO toReturn = new loginDTO();
            myConnection.SqlCon.Open();

            string queryString = "SELECT * FROM myUsers WHERE username=@username " +
                "AND passwords=@password;";

            SqlCommand com = new SqlCommand(queryString, myConnection.SqlCon);
            com.Parameters.AddWithValue("@username", login.Username);
            com.Parameters.AddWithValue("@password", login.Password);


            SqlDataReader reader = com.ExecuteReader();
            while (reader.Read())
            {
                toReturn.Username = reader["username"].ToString();
                toReturn.Password = reader["passwords"].ToString();
                toReturn.Role = reader["role"].ToString();
            }
            reader.Close();
            myConnection.SqlCon.Close();
            return toReturn;

        }
    }
}
