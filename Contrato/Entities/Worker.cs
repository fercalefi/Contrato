using System;
using System.Collections.Generic;
using System.Text;
using Contrato.Entities.Enums;

namespace Contrato.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }

        // criando uma propriedade do tipo lista e já instanciando em memória
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

   


        //construtor sem parametro
        public Worker()
        {
        }

        // construtor com parametros
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Level
                + ", "
                + BaseSalary;
        }

        public void addContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void removeContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double income(int year, int month)
        {
            foreach (HourContract obj in Contracts) 
            {
                if (obj.Date.Month == month && obj.Date.Year == year)
                {
                    BaseSalary += obj.TotalValue();
                }


            }
            return BaseSalary;

     
        }
    }
}
