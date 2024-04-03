using System;

class Program
{
    static void Main()
    {   // Pedir o nome completo

        Console.Write("Digite seu nome completo: ");

        string nome = Console.ReadLine();

        // Pedir a data de nascimento
        Console.Write("Digite sua data de nascimento (no formato dd/mm/aaaa): ");

        string dt_nascimento = Console.ReadLine();

        // Converter a entrada para DateTime
        DateTime dataNascimento;

        // Tentar converter a entrada para DateTime
        if (DateTime.TryParseExact(dt_nascimento, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dataNascimento))
        {
            int idade = CalcularIdade(dataNascimento);
            Console.WriteLine("Olá, " + nome + "! Sua idade é: " + idade + " anos.");
        }
        else
        {
            // Se a conversão falhar, exibir uma mensagem de erro
            Console.WriteLine("Entrada inválida. Por favor, insira uma data válida no formato dd/mm/aaaa.");
        }

        // Aguardar o usuário pressionar uma tecla antes de fechar o console
        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    // calcular a idade com base na data de nascimento fornecida pelo usuário
    static int CalcularIdade(DateTime dataNascimento)
    {
        DateTime dataAtual = DateTime.Today;
        int idade = dataAtual.Year - dataNascimento.Year;

        // Verificar se já fez aniversário neste ano
        if (dataNascimento > dataAtual.AddYears(-idade))
        {
            idade--;
        }

        return idade;
    }
}

