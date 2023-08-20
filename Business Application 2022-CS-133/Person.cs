using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2nd_semester_Final_Project
{
    public class Person
    {
        protected Credentials crd = new Credentials();

        public Person()
        {

        }
        public Person(Credentials crd)
        {
            this.crd = crd;
        }

        public void SetUser(Credentials crd)
        {
            this.crd = crd;
        }

        public Credentials GetUser()
        {
            return this.crd;
        }

        public string getRole()
        {
            return $"{crd.GetRole(),-25}";

        }


    }
}
