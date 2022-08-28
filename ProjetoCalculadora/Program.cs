using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCalculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Sair }


        static void Main(string[] args)
        {
            bool escolheuSair = false;
            while(!escolheuSair)
            {
                Console.WriteLine("Bem vindo(a) a Calculadora!");
                Console.WriteLine("Selecione uma das opções:");
                Console.WriteLine("1-Soma\n2-Subtração\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case Menu.Soma:
                        Soma();
                        break;
                    case Menu.Subtracao:
                        Subtracao();
                        break;
                    case Menu.Divisao:
                        Divisao();
                        break;
                    case Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case Menu.Potencia:
                        Potencia();
                        break;
                    case Menu.Raiz:
                        Raiz();
                        break;
                    case Menu.Sair:
                        escolheuSair = true;
                        break;
                }
                
                Console.Clear();
            }
        }

        static void Soma()
        {
            Console.WriteLine("Soma de dois Numeros!");
            Console.WriteLine("Digite o 1° valor:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine("O Resultado da soma é: " + resultado);
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Subtracao()
        {
            Console.WriteLine("Subtração de dois Numeros!");
            Console.WriteLine("Digite o 1° valor:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine("O Resultado da subtração é: " + resultado);
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Divisao()
        {
            Console.WriteLine("Divisão de dois Numeros!");
            Console.WriteLine("Digite o 1° valor:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor:");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine("O Resultado da divisão é: " + resultado);
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Multiplicação de dois Numeros!");
            Console.WriteLine("Digite o 1° valor:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o 2° valor:");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine("O Resultado da multiplicação é: " + resultado);
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Potencia()
        {
            Console.WriteLine("Potência de um Numero!");
            Console.WriteLine("Digite o valor da base:");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente :");
            int expo = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(baseNum, expo);
            Console.WriteLine("O Resultado é: " + resultado);
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
        }

        static void Raiz()
        {
            Console.WriteLine("Raiz de um Numero!");
            Console.WriteLine("Digite o numero:");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine("O Resultado é: " + resultado);
            Console.WriteLine("Aperte Enter para voltar ao menu");
            Console.ReadLine();
        }
    }
}
