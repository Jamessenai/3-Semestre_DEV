namespace Exercicio5
{
public class Funcionario : Pessoa
    {
        public double Salario = 0.0;
        public void ExibirDados()
        {
            base.ExibirDados();
            Console.WriteLine($"Salário: {Salario}");
        }
    }
}
