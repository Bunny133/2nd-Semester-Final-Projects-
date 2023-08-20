using System;
using System.Windows.Forms;

namespace _2nd_semester_Final_Project
{
    class Program
    {

        public static string path = "storeUser.txt";
        public static string path2 = "storePassenger.txt";
        public static string Path = "StoreFlight.txt";
        public static string path3 = "StoreFeedback.txt";
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SIgnupForm());



        }
    }
}