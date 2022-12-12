using driving_center;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Driving_Center
{
    public class Student
    {
        public string firstName;
        public string lastName;
        public string nationalCode { get; set; }
        public string birthDate;


        public void Registreation()
        {
            Console.WriteLine("Enter FirstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter LastName");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter NationalCode");
            string code = Console.ReadLine();

            Console.WriteLine("Enter Birth Date");
            string date = Console.ReadLine();

            Program.studentList.Add(new Student { firstName = firstName, lastName = lastName, nationalCode = code, birthDate = date });

        }

        public void List()
        {
            for (int j = 0; j < Program.studentList.Count; j++)
            {

                Console.Write(Program.studentList[j].firstName + "  ");
                Console.Write(Program.studentList[j].lastName + "  ");
                Console.Write(Program.studentList[j].nationalCode + "  ");
                Console.WriteLine(Program.studentList[j].birthDate);

            }
        }
        private  void search(string snationalcode,int studentcounter, string[,] studentarray)
        {
        }
        public void Edite()
        {
            Console.WriteLine("Please Enter National Code");
            string nationalCode = Console.ReadLine();

            bool thereIsNational = Program.studentList.Exists(x => x.nationalCode == nationalCode);

            if (thereIsNational == true)
            {
                var studentElement = from s in Program.studentList
                                     where s.nationalCode == nationalCode
                                     select s;

                Console.WriteLine("Enter  irstName");
                firstName = Console.ReadLine();
                Console.WriteLine("Enter LastName");
                lastName = Console.ReadLine();
                Console.WriteLine("Enter Birth Date");
                birthDate = Console.ReadLine();

                foreach (var stu in studentElement)
                {
                    stu.firstName = firstName;
                    stu.lastName = lastName;
                    stu.birthDate = birthDate;
                }
            }
            else
            {
                Console.WriteLine("There Is No Student With This National Code");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Please Enter National Code  ");
            nationalCode = Console.ReadLine();

            var stuntElement = from s in Program.studentList
                               where s.nationalCode == nationalCode
                               select s;
            int find = 0;
            for (int counter = 0; counter < Program.studentList.Count; counter++)
            {
                if (Program.studentList[counter].nationalCode == nationalCode)
                {
                    Program.studentList.RemoveAt(counter);
                    find = 1;
                }
            }
            if (find ==0)
                Console.WriteLine("there is no student whith this national Number");
            else
                Console.WriteLine(" student details deleted");
           
        }

    }
}
