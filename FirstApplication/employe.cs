using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{
    public class employee
    {
        public string name;
        public string department;
        public int years_of_experience;
        public string contact;
        public DateTime DOB;
        public string img;
        public employee()
        {
            name = "";
            department = "";
            years_of_experience = 0;
            contact = null;
            DOB = DateTime.Now;

        }
        public override string ToString()
        {
            string str= "Name : "+name+"\nDepartment : "+department+"\n"+
                "Years of Experience : "+years_of_experience+"\n"+
                "Age : " + (DateTime.Now.Year - DOB.Year) + "\n"+
                "Contact Number : " + contact;
            return str;
        }
    }
}
