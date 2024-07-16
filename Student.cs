using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExampleFIRSTWpfProfile
{ //public we want to be able to access the class ffom utside. so change to public when we want to call a class from outside 
    public class Student
    {
        private string name; 
       private  string surname;
        private string emailID;
        private string password;
        private string address;

        public Student()
        {
        }

        public Student(string name, string surname, string emailID, string password, string address)
        {
            this.name = name;
            this.surname = surname;
            this.emailID = emailID;
            this.password = password;
            this.address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string EmailID { get => emailID; set => emailID = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
    }
   
}
