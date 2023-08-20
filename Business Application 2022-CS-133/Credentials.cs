using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using _2nd_semester_Final_Project;

namespace _2nd_semester_Final_Project
{
    public class Credentials
    {
        private string userName = "";
        private string userPassword = "";
        private string role = "";

        public string UserName { get => userName; set => userName = value; }
        public string UserPassword { get => userPassword; set => userPassword = value; }
        public string Role { get => role; set => role = value; }

        public string GetPassword()
        {
            return this.userPassword;
        }
        public string GetRole()
        {
            return this.role;
        }

      
        public void SetPassword(string userPassword)
        {
            this.userPassword = userPassword;
        }
        public void SetRole(string role)
        {
            this.role = role;
        }
        public Credentials(string userName, string userPassword, string role)
        {
            this.userName = userName;
            this.userPassword = userPassword;
            this.role = role;
        }
        public Credentials()
        {

        } 
        public Credentials(string userPassword,string role)
        {
            this.userPassword=userPassword;
            this.role=role;
        }


        public string validUser(Credentials existingUser)
        {
            foreach (Credentials user in MUserDL.usersList)
            {
                if (user.userName == existingUser.userName && user.userPassword == existingUser.userPassword)
                {
                    return user.role;
                }
            }
            return "User Not Found";
        }

        public virtual string toString()
        {
            return (userName + "\t");
        }
    }
}