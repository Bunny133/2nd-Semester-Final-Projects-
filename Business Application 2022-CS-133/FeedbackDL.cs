using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2nd_semester_Final_Project
{
    class FeedbackDL
    {
        public static List<FeedBack> feeds = new List<FeedBack>();


        public static void StoreFeedback(string path3)
        {


            StreamWriter storeFeedback = new StreamWriter(path3);
            foreach (FeedBack user in FeedbackDL.feeds)
            {
                storeFeedback.WriteLine(user.Name + "," + user.Feedback);
            }
            storeFeedback.Flush();
            storeFeedback.Close();
        }

        public static void LoadFeedback(string path)
        {
            if (File.Exists(path))
            {
                StreamReader storeUser = new StreamReader(path,true);
                string line;
                while ((line = storeUser.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    string name = splittedRecord[0];
                    string feedback = splittedRecord[1];

                    FeedBack feedBack = new FeedBack(name, feedback);
                    feeds.Add(feedBack);


                }
                storeUser.Close();


            }
        }
    }
}
