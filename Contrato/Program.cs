using System;
using System.Globalization;
using Contrato.Entities;
using Contrato.Entities.Enums;
using System.Collections.Generic;

namespace Contrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string nameDepartament = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // instanciando objetos
            Departament departament = new Departament(nameDepartament);
            Worker worker = new Worker(name, level, salary, departament);


            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());


            // instanciando uma lista de contratos
           // List<HourContract> contratoLista = new List<HourContract>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");

                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                // adicionando o contrato na lista
                HourContract contrato = new HourContract(date, valuePerHour, hours);
                worker.addContract(contrato);
            }

            Console.Write("Enter mont and year to calculate income (MM/YYYY): ");
            string monthYear = Console.ReadLine();


            int month = int.Parse(monthYear.Substring(0, 2));
            //string teste = monthYear.Substring(2, 4);
            int year = int.Parse(monthYear.Substring(3, 4));

            Console.WriteLine("Name: "+ worker.Name);
            Console.WriteLine("Departament: "+ worker.Departament.Name);
            Console.WriteLine("Income for "+ monthYear +": "+ worker.income(year, month));




        }
    }
}
