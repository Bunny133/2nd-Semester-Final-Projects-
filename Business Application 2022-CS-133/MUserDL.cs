using System;
using System.Collections.Generic;
using System.IO;

namespace _2nd_semester_Final_Project
{
    public class MUserDL
    {


        public static List<Credentials> usersList = new List<Credentials>();
         
        public static bool addUser(Credentials newUser, string path)
        {
            Person obj = new Person();
            bool flag = true;
            foreach (Credentials u in usersList)
            {
                if (obj.getRole() == "Admin")
                {
                    if (u.GetPassword() == newUser.GetPassword() && u.UserName == newUser.UserName)
                    {
                        flag = true;
                       
                        break;
                    }
                    else
                    {
                        flag = false;
                    }
                    
                }
                else
                {
                    flag = false;
                }
            }
            if (obj.getRole() == "Customer")
            {

                foreach (Credentials s in usersList)
                {
                    if (s.UserName == s.UserName && s.GetPassword() == s.GetPassword())
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        flag = false;
                     
                                                                  
                    }
                }
            }
            if (flag == true)
            {
                usersList.Add(newUser);
                storeUser(path, newUser);
              
            }
            return flag;
        }
        public static void storeUser(string path, Credentials newUser)
        {
            StreamWriter storeUser = new StreamWriter(path, true);
            foreach (Credentials user in usersList)
            {
                storeUser.WriteLine(user.UserName + "," + user.GetPassword() + "," + user.GetRole());
            }
            storeUser.Close();
        }
        public static Credentials search(string name,string password)
        {
            foreach (Credentials user in MUserDL.usersList)
            {
                if (name==user.UserName&&password==user.UserPassword)
                {
                    return user;
                }
            }
            return null;
        }
        public static Credentials search(string name)
        {
            foreach (Credentials user in MUserDL.usersList)
            {
                if (name == user.UserName)
                {
                    return user;
                }
            }
            return null;
        }
        public static bool loadUser(string path)
        {
            string line;
            if (File.Exists(path))
            {
                StreamReader storeUser = new StreamReader(path);
                while ((line = storeUser.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');
                    if (splittedRecord.Length >= 3)
                    {
                        Credentials newUser = new Credentials();
                        newUser.UserName=(splittedRecord[0]);
                        newUser.SetPassword(splittedRecord[1]);
                        newUser.SetRole(splittedRecord[2]);
                        usersList.Add(newUser);
                    }
                    else
                    {
                       
                    }
                }
                storeUser.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}

