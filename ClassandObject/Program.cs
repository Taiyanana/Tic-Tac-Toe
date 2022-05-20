using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassandObject
{
    //class
    class Student
    {
        //fields
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        //methods
        public void ShowDetails()
        {
            Console.WriteLine("Student Information");
            Console.WriteLine("StudentId:{0}, Name: {1}, Address:{2}", StudentId, Name, Address);
        }
    }
}
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
       /// [STAThread]
   
        static void Main(string[] args)
        {
        //object
        Student st = new Student();
        st.StudentId = 1;
        st.Name = "Aisha";
        st.Address = "Taiya";

        st.ShowDetails();
        Console.ReadKey();

        }
    }

internal class Student
{
    internal int StudentId;
    internal string Address;
    internal string Name;

    internal void ShowDetails()
    {
        throw new NotImplementedException();
    }
}