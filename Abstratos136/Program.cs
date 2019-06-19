using System;
using System.Collections.Generic;
using System.Globalization;
using Abstratos136.Entities;

namespace Abstratos136
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            // cria uma lista do type Payes. Obs não é permitido instanciar se não for uma lista.
            List<Payers> list = new List<Payers>();

            for (int i= 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());

                // dados comuns entre os dois tipos de classes (individual e comopany)
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (ch == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    //Adiciona a lista instanciando a classe Individual
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int employeesNumber = int.Parse(Console.ReadLine());

                    //Adiciona a lista instanciando a classe Company
                    list.Add(new Company(name, anualIncome, employeesNumber));
                }
            }

            // Impressão dos dados em tela 
            Console.WriteLine();
            Console.WriteLine("TAXES PAID");

            //PERCORRE A LISTA DE CONTRIBUINTES
            double totalTaxes = 0;

            foreach (Payers item in list)
            {

                Console.WriteLine(item.Name
                                  + ": $ "
                                  + item.taxesPaid().ToString("F2", CultureInfo.InvariantCulture));

                totalTaxes += item.taxesPaid();
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("TOTAL TAXES: $"+totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
