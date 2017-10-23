using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Saída 1 com WriteLine()");
            //Console.WriteLine("Saída 2 com WriteLine()");
            //Console.Write("Saída 1 com Write()");
            //Console.Write("Saída 2 com Write()");
            //Console.Write("\n");

            // Concatenação
            //string nome = "Bruno";
            //string sobrenome = "Freitas";
            //int idade = 32;

            //Console.WriteLine("Meu nome é " + nome + " " + sobrenome + " e tenho " + idade + " anos.");
            //Console.WriteLine("Meu nome é {0} {1} e tenho {2} anos.", nome, sobrenome, idade);
            //string texto = string.Format("Meu nome é {0} {1} e tenho {2} anos.", nome, sobrenome, idade);
            //Console.WriteLine(texto);

            // Formatação de tipos
            //Console.WriteLine("Sem Currency {0}", 2.5);
            //Console.WriteLine("Com Currency {0:C}", 2.5);
            //Console.WriteLine("Decimal {0:D3}", 25);
            //Console.WriteLine("Scientific {0:E}", 25000);
            //Console.WriteLine("Fixed-Point {0:F3}", 25);
            //Console.WriteLine("Fixed-Point {0:F0}", 25);
            //Console.WriteLine("Hexadecimal {0:X}", 250);

            // Operações de entrada
            //Console.Write("Entre com um caractere:");
            //int x = Console.Read();
            //char ch = Convert.ToChar(x);
            //Console.WriteLine("Caractere que você digitou {0}", ch);

            Console.WriteLine("Entre com várias linhas:");
            string linha;
            do
            {
                linha = Console.ReadLine();
                if (linha != null)
                {
                    Console.WriteLine("Linha: {0}", linha);
                }
            } while (linha != null);
        }
    }
}
