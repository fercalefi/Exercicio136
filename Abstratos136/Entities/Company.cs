using System;
using System.Collections.Generic;
using System.Text;

namespace Abstratos136.Entities
{
    class Company : Payers
    {
        public int EmployeesNumber { get; set; }

        public Company(string name, double anualIncome, int employeesNumber) :base(name, anualIncome)
        {
            EmployeesNumber = employeesNumber;
        }

        // sobreescreve o metodo taxesPaid da superclasse (classe abstrata força a subclasse a ter o método pai)
        public override double taxesPaid()
        {
            double taxesPaid = 0;

            if (EmployeesNumber > 10)
            {
                taxesPaid = AnualIncome * 0.14;
            }
            else
            {
                taxesPaid = AnualIncome * 0.16;
            }

            return taxesPaid;

        }

    }
}
