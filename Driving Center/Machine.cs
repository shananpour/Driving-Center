using driving_center;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_Center
{
    class Machine
    {
        public string model;
        public string brand;
        public string ProductionYear;
        public string price;
        public string numberPlate;

        public int registreation( int machinecounter, string[,] machinetarray)
        {
            Console.WriteLine("Enter model");
            string model = Console.ReadLine();
            Console.WriteLine("Enter brand");
            string brand = Console.ReadLine();
            Console.WriteLine("Enter ProductionYear");
            string ProductionYear = Console.ReadLine();
            Console.WriteLine("Enter price");
            string price = Console.ReadLine();
            Console.WriteLine("Enter numberPlate");
            string numberPlate = Console.ReadLine();
           /* Program.machinearray.Add(model);
            Program.machinearray.Add(brand);
            Program.machinearray.Add(ProductionYear);
            Program.machinearray.Add(price);
            Program.machinearray.Add(numberPlate);*/

            machinetarray[machinecounter, 0] = model;
            machinetarray[machinecounter, 1] = brand;
            machinetarray[machinecounter, 2] = ProductionYear;
            machinetarray[machinecounter, 3] = price;
            machinetarray[machinecounter, 4] = numberPlate;
            machinecounter++;
            
            return machinecounter;
           
        }

       public void list(string[,] machinetarray, int machinecounter)
        {
            //int count=Program.machinearray.Count;
          //  for(int i=0; i< count;i++) 
         
            for (int i = 0; i <= machinecounter; i++)
            {
                for (int j = 0; j < machinetarray.GetLength(1); j++)
                {
                    Console.Write(machinetarray[i, j] + "  ");
                }
                Console.WriteLine(" ");
            }
           /* foreach(string i in machinetarray)
            {
                Console.WriteLine(i);
            }*/
        }

        private int search(string numberPlate, string[,] machinetarray, int machinecounter)
        { 
             int numberofrow = -1;
            Console.WriteLine(numberofrow);
            for (int i = 0; i <= machinecounter; i++)
              {
                  for (int j = 0; j < machinetarray.GetLength(1); j++)
                  {
                      if (machinetarray[i, j] == numberPlate)
                      {
                        numberofrow = i;
                          j = machinetarray.GetLength(1) + 1;
                          i = machinecounter + 1;
                        Console.WriteLine(numberofrow);
                    }

                  }
              }
            return numberofrow;
        }

        public void Edite(string numberPlate, string[,] machinetarray, int machinecounter)
        {
            int i = search(numberPlate, machinetarray, machinecounter);
            if (i != -1)
            {
                Console.Write("Enter model ");
                machinetarray[i, 0] = Console.ReadLine();
                Console.Write("Enter brand ");
                machinetarray[i, 1] = Console.ReadLine();
                Console.Write("Enter ProductionYear ");
                machinetarray[i, 2] = Console.ReadLine();
                Console.Write("Enter price ");
                machinetarray[i, 3] = Console.ReadLine();
            }
        }
        public int Delete(string numberPlate, string[,] machinetarray, int machinecounter)
        {
            int i = search(numberPlate, machinetarray, machinecounter);
            if (i != -1)
            {
                for (int j = 0; j < 5; j++)
                    machinetarray[i, j] = null;

                for (int c = i; c < machinecounter; c++)
                {
                    for (int j = 0; j < 5; j++)
                        machinetarray[c, j] = machinetarray[c + 1, j];
                }
                machinecounter--;
            }
            return machinecounter;
        }
    }
}
