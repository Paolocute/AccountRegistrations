using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountRegistration
{
    public delegate long DelegateNumber(long number);
    public delegate string DelegateText(string txt);
    internal class StudentInfoClass
    {
        public static string FirstName = "";
        public static string LastName = "";
        public static string MiddleName = "";
        public static string Address = "";
        public static string Program = "";

        public static long Age = 0;
        public static long ContactNo = 0;
        public static long StudentNo = 0;

        public static string GetFirstName (string FirstName) { return FirstName; }
        public static string GetLastName(string LastName) { return LastName; }
        public static string GetMiddleName (string MiddleName) { return MiddleName; }
        public static string GetAddress (string Address) { return Address; }
        public static string GetProgram (string Program) { return Program; }

        public static long GetAge (long Age) { return Age; }
        public static long GetContact(long Contact) { return Contact; }
        public static long GetStudentNo(long StudentNo) { return StudentNo; }


          
    }
}
