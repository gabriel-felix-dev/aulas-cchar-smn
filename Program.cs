using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;

namespace aulas_charp_smn;

class Program
{

    //static int[] numero = new int[3];
    static void Main(string[] args)
    {
        Console.Clear();

        /*#### Questão 1 ####

        bool exit = true;
        while (exit)
        {
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - adicionar número");
            Console.WriteLine("2 - listar ");
            Console.WriteLine("3 - sair");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdcionarNumero();
                    break;
                case "2":
                    Listar();
                    break;
                case "3":
                    exit = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }
        }*/

        /*#### Questão 3 #### 
        var contadorTentativas = 1;
        bool validadorDeAcesso = true;
        var codigoDeAcesso = 2025;

        while (contadorTentativas <= 3 && validadorDeAcesso)
        {
            Console.WriteLine($"{contadorTentativas} Tentativa - Digite o código de acesso:");
            var codigoDgitado = int.Parse(Console.ReadLine());

            if (contadorTentativas == 3)
            {
                Console.WriteLine("Número de tentativas excedidas! Acesso bloqueado!");
                validadorDeAcesso = false;
            }
            else if (codigoDgitado != codigoDeAcesso)
            {
                Console.WriteLine("Código incorreto!");
                contadorTentativas++;
            }
            else
            {
                Console.WriteLine("Acesso autorizado!");
                validadorDeAcesso = false;
            }
        }*/

        /*#### Questão 4 ####

        decimal[] notas = new decimal[3];

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Digite a {i + 1}° nota:");
            notas[i] = decimal.Parse(Console.ReadLine());

        }

        decimal media = (notas[0] + notas[1] + notas[2]) / 3;

        Console.WriteLine($"\nMédia do aluno {media:F1}");

        if (media < 5)
        {
            Console.WriteLine("Reprovado!");
        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("Recuperação!");
        }
        else
        {
            Console.WriteLine("Aprovado!");
        }*/

        /*#### Questão 5 ####

        Console.WriteLine("Digite um número entre 1 e 100:");
        int numero = int.Parse(Console.ReadLine());

        while (numero < 1 || numero > 100)
        {
            Console.WriteLine("\nNúmero digitado inválido!!!\n");

            Console.WriteLine("Digite um número entre 1 e 100:");
            numero = int.Parse(Console.ReadLine());
        }

        bool primo = true;

        if (numero == 1)
        {
            primo = false;
        }
        else
        {
            for (int i = 2; i * i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    primo = false;
                    break;
                }
            }
        }

        if (primo)
        {
            Console.WriteLine($"O número {numero} é primo");
        }
        else
        {
            Console.WriteLine($"O número {numero} não é primo");
        }*/

    }

    /*static void AdcionarNumero()
    {
        for (var i = 0; i < 3; i++)
        {
            Console.WriteLine("Escreva um número");
            string numeroLeitura = Console.ReadLine();
            int leitura;
            if (!int.TryParse(numeroLeitura, out leitura))
            {
                Console.WriteLine("Digite um numero");
                i--;
            }

            numero[i] = leitura;
        }       
    }*/

    /*static void Listar()
    {
        foreach (var item in numero)
        {
            Console.WriteLine(item);
        }

    }*/

}
