using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1st
{
    internal class Program
    {
        public delegate void StudentDetails<L>(L inpi);

        private static string name;
        private static int id;
        private string StudentAddress;

        public string getAddress()
        {
            return StudentAddress;  
        }

        public void setAddress(string StdAddress)
        {
            StudentAddress = StdAddress;
        }

        public static void getName(string Name)
        {
            name = Name;
            Console.WriteLine("Student name: " + Name);
        }

        public static void getId(int Id)
        {
            id = Id;
            Console.WriteLine("Student id: "+Id);
        }

        public void Dictionary_Store()
        {
            Dictionary<int, string> DS = new Dictionary<int, string>();
            DS.Add(1, id.ToString());
            DS.Add(2, name);
            DS.Add(3, StudentAddress);

            Console.WriteLine("\n");

            foreach(KeyValuePair<int, string> i in DS){
                Console.WriteLine(" " + i.Value);
            }
        }
        static void Main(string[] args)
        {
            StudentDetails<string> moi = new StudentDetails<string>(getName);
            moi.Invoke("Binta");
            StudentDetails<int> ID = new StudentDetails<int>(getId);
            ID.Invoke(876);

            Program P = new Program();
            P.setAddress("Buloba");
            P.Dictionary_Store();
        }
    }
}
