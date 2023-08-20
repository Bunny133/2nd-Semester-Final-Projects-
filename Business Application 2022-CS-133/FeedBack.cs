using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_semester_Final_Project
{
    public class FeedBack
    {
        private string name;
        private string feedback;
       

        public string Name { get => name; set => name = value; }
        public string Feedback { get => feedback; set => feedback = value; }
        


        public FeedBack(string name,string feedback)
        {
            this.Name = name;
            this.Feedback = feedback;
        }
      
        

    }
}
