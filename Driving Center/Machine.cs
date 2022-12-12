using driving_center;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace Driving_Center
{
    public class Machine
    {
        public string model;
        public string brand;
        public string numberPlate;
        public string ProductionYear;
        public string price;


        public void Registreation()
        {
            Console.WriteLine("Enter model");
            model = Console.ReadLine();
            Console.WriteLine("Enter brand");
            brand = Console.ReadLine();
            Console.WriteLine("Enter numberPlate");
            numberPlate = Console.ReadLine();
            Console.WriteLine("Enter ProductionYear");
            ProductionYear = Console.ReadLine();
            Console.WriteLine("Enter price");
            price = Console.ReadLine();

            Program.machineList.Add(new Machine { model = model, brand = brand, numberPlate = numberPlate, ProductionYear = ProductionYear, price = price });

        }

        public void List()
        {
            for (int j = 0; j < Program.machineList.Count; j++)
            {

                Console.Write(Program.machineList[j].model + "  ");
                Console.Write(Program.machineList[j].brand + "  ");
                Console.Write(Program.machineList[j].numberPlate + "  ");
                Console.Write(Program.machineList[j].ProductionYear + "  ");
                Console.WriteLine(Program.machineList[j].price);

            }
        }

        private int search(string numberPlate, string[,] machinetarray, int machinecounter)
        {
            int numberofrow = -1;
            for (int i = 0; i <= machinecounter; i++)
            {
                for (int j = 0; j < machinetarray.GetLength(1); j++)
                {
                    if (machinetarray[i, j] == numberPlate)
                    {
                        numberofrow = i;
                        j = machinetarray.GetLength(1) + 1;
                        i = machinecounter + 1;
                    }

                }
            }
            return numberofrow;
        }

        public void Edite()
        {
            Console.WriteLine("Please Enter numberPlate");
            numberPlate = Console.ReadLine();

            bool thereIsNational = Program.machineList.Exists(x => x.numberPlate == numberPlate);

            if (thereIsNational == true)
            {
                var studentElement = from s in Program.machineList
                                     where s.numberPlate == numberPlate
                                     select s;

                Console.WriteLine("Enter  model");
                model = Console.ReadLine();
                Console.WriteLine("Enter brand");
                brand = Console.ReadLine();
                Console.WriteLine("Enter ProductionYear ");
                ProductionYear = Console.ReadLine();
                Console.WriteLine("Enter price ");
                price = Console.ReadLine();

                foreach (var stu in studentElement)
                {
                    stu.model = model;
                    stu.brand = brand;
                    stu.ProductionYear = ProductionYear;
                    stu.price = price;
                }
            }
            else
            {
                Console.WriteLine("There Is No Machine With This Number Plate");
            }
        }
        public void Delete()
        {
            Console.WriteLine("Please Entern Nmber Plate  ");
            numberPlate = Console.ReadLine();

            var stuntElement = from s in Program.machineList
                               where s.numberPlate == numberPlate
                               select s;
            int find = 0;
            for (int counter = 0; counter < Program.machineList.Count; counter++)
            {
                if (Program.machineList[counter].numberPlate == numberPlate)
                {
                    Program.machineList.RemoveAt(counter);
                    find = 1;
                }
            }
            if (find == 0)
                Console.WriteLine("there is no Machine whith this Nmber Plate ");
            else
                Console.WriteLine(" Machine Details Deleted");
        }
    }
}
