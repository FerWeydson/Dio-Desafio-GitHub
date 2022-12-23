
using Interface;
class Program
{
    static void Main(String[] args)
    {
        Motorista motorista1 = new Motorista();
        motorista1.Nome = "Fábio";
        motorista1.Sobrenome = "t-guel";
        motorista1.Salario = 1000.50f;

        Motorista motorista2 = new Motorista();
        motorista2.Nome = "Nico";
        motorista2.Sobrenome = "Flau";
        motorista2.Salario = 15f;
    }
}