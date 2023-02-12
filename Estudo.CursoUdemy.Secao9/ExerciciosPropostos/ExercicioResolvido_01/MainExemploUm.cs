using Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioResolvido_01.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.CursoUdemy.Secao9.ExerciciosPropostos.ExercicioResolvido_01
{
    public static class MainExemploUm
    {

        public static void Executar()
        {

            Console.Write("Enter departament's name: ");
            string departament = Console.ReadLine();

            Console.WriteLine("\nEnter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level(Junior/MidLevel/Senior): ");
            string level = Console.ReadLine();

            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("How many contracts to this worker? ");
            int qntContracts = Convert.ToInt32(Console.ReadLine());


            Departament dep = new Departament(departament);
            Worker worker = new Worker(name, level, salary, dep);

            for (int i = 1; i <= qntContracts; i++)
            {
                Console.WriteLine($"Enter {i}° contract data: ");
                Console.Write("Date (dd/mm/yyyy): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valueHour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int qntHours = Convert.ToInt32(Console.ReadLine());

                HourContract contract = new HourContract(date, valueHour, qntHours);
                worker.addContract(contract);

                }

             Console.Write("Enter month and year to calculate incole(mm/yyyy): ");
            string seach = Console.ReadLine();
            //DateTime search = Convert.ToDateTime(Console.ReadLine());

            int month = Convert.ToInt32(seach.Substring(0, 2));
            int year = Convert.ToInt32(seach.Substring(3));

            double totalValue = worker.income(month, year);

            //int month = 8;
            //int year = 2018;

            //Departament dep = new Departament("Design");

            //Worker worker = new Worker("Alex", "MidLevel", 1200, dep);

            //DateTime hora1 = DateTime.Parse("20/08/2018"); 
            //HourContract cont1 = new HourContract(hora1,50,20);
            //worker.addContract(cont1);

            //DateTime hora2 = DateTime.Parse("13/06/2018");
            //HourContract cont2 = new HourContract(hora2, 30, 18);
            //worker.addContract(cont2);

            //DateTime hora3 = DateTime.Parse("13/08/2018");
            //HourContract cont3 = new HourContract(hora3, 80, 10);
            //worker.addContract(cont3);

            Console.WriteLine($"Name: {worker.Nome}");
            Console.WriteLine($"Departament: {worker.Departament.Name}");
            Console.WriteLine($"income for {month}/{year}: {worker.income(month,year)}");




        }

    }
}
