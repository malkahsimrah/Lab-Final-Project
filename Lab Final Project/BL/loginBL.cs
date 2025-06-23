using Lab_Final_Project.DL;
using Lab_Final_Project.DTO;
using Lab_Final_Project.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Lab_Final_Project.BL
{
    public class loginBL
    {
        loginDL loginDL;

        public loginDL LoginDL { get => loginDL; set => loginDL = value; }

        public loginBL()
        {
            loginDL = new loginDL();
        }

        public Form VerifyUser(loginDTO loginDTO)
        {
            loginDTO toReturn = loginDL.verifyUserFromDB(loginDTO);

            if (toReturn == null || string.IsNullOrEmpty(toReturn.Role))
            {
                return new WrongGUI();
            }
            else if (toReturn.Role.Equals("Student", StringComparison.OrdinalIgnoreCase))
            {
                return new StudentTranscriptGUI();
            }
            else if (toReturn.Role.Equals("Faculty", StringComparison.OrdinalIgnoreCase))
            {
                return new AssessmentFormGUI();
            }
            else
            {
                return new WrongGUI();
            }
        }

    }
}
