using System;
using System.Collections.Generic;
using System.Text;

namespace Abstratos136.Entities
{
    abstract class Payers
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Payers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        // implementa um metodo abstrato generico para que as subclasses implementem as regras (taxesPaid = imposto pago)
        public abstract double taxesPaid();
    }

}
