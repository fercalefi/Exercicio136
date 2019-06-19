namespace Abstratos136.Entities
{
    class Individual : Payers
    {
        // HealthExpenditures = gastos com saude
        public double HealthExpenditures { get; set; }

        // cria o construtor e herda as  propriedades name a anualIncome da clsse Payers
        public Individual(string name, double anualIncome, double healthExpenditures): base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        // cria o metodo taxesPaid 
        public override double taxesPaid()
        {
            double taxesPaid = 0;
    
            // se o ganho anual for menor que 2000 então a taxa é de 15%.
            if (AnualIncome < 20000)
            {
                taxesPaid =  0.15;
            }
            // se o ganho anual for maior ou igual a 2000 então a taxa é de 25%
            else
            {
                taxesPaid =  0.25;
            }

            // se tiver gasto com saúde, é abatido 50% do valor gasto da taxa de imposto
            return (AnualIncome * taxesPaid) - (HealthExpenditures * 0.5);
        }
    }
}
