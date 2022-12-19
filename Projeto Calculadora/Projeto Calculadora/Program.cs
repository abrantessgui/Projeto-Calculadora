using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calculadora
{
    internal class Program
    {
        enum Menu { SOMA = 1, SUBTRAÇAO = 2, DIVISAO =3, MULTIPLICAÇAO = 4, POTENCIA = 5, RAIZ = 6, SAIR = 7 }
        static void Main(string[] args)
        {
            bool escolheuSAIR = false;
            while (!escolheuSAIR)
            {
                Console.WriteLine("calculadora SENAI");
                Console.WriteLine("");
                Console.WriteLine("Selecione uma das Opções: ");
                Console.WriteLine("");
                Console.WriteLine("1-SOMA\n\n2-SUBTRAÇAO\n\n3-DIVISAO\n\n4-MULTIPLICAÇAO\n\n5-POTENCIA\n\n6-RAIZ\n\n7-SAIR");
                Console.WriteLine("");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case Menu.SOMA:
                        SOMA();
                        break;

                    case Menu.SUBTRAÇAO:
                        SUBTRAÇAO();
                        break;

                    case Menu.DIVISAO:
                        DIVISAO();
                        break;

                    case Menu.MULTIPLICAÇAO:
                        MULTIPLICAÇAO();
                        break;

                    case Menu.POTENCIA:
                        POTENCIA();
                        break;

                    case Menu.RAIZ:
                        RAIZ();
                        break;

                    case Menu.SAIR:
                        escolheuSAIR = true;
                        break;
                }
                Console.Clear();
            }

         }

        static void SOMA()
        {
            Console.WriteLine("");
            Console.WriteLine("SOMA DE DOIS NUMEROS: ");
            Console.WriteLine("");
            Console.WriteLine("DIGITE O PRIMEIRO NUMERO: ");
            Console.WriteLine("");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("DIGITE O SEGUNDO NUMERO: ");
            Console.WriteLine("");
            int b = int.Parse(Console.ReadLine());
            int resultado = a + b;
            Console.WriteLine("");
            Console.WriteLine($"O RESULTADO DA SUA SOMA É: \n\n[   {resultado}   ]");
            Console.WriteLine("");
            Console.WriteLine("APERTE ENTER PARA VOLTAR PARA O MENU");

            Console.ReadLine();

        }

        static void SUBTRAÇAO()
        {
            Console.WriteLine("");
            Console.WriteLine("SUBTRAÇAO DE DOIS NUMEROS: ");
            Console.WriteLine("");
            Console.WriteLine("DIGITE O PRIMEIRO NUMERO: ");
            Console.WriteLine("");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("DIGITE O SEGUNDO NUMERO: ");
            Console.WriteLine("");
            int b = int.Parse(Console.ReadLine());
            int resultado = a - b;
            Console.WriteLine("");
            Console.WriteLine($"O RESULTADO DA SUA SUBTRAÇAO É: \n\n[   {resultado}   ]");
            Console.WriteLine("");
            Console.WriteLine("APERTE ENTER PARA VOLTAR PARA O MENU");

            Console.ReadLine();
  
        }

        static void DIVISAO()
        {
            Console.WriteLine("");
            Console.WriteLine("DIVISAO DE DOIS NUMEROS: ");
            Console.WriteLine("");
            Console.WriteLine("DIGITE O PRIMEIRO NUMERO: ");
            Console.WriteLine("");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("DIGITE O SEGUNDO NUMERO: ");
            Console.WriteLine("");
            int b = int.Parse(Console.ReadLine());
            float resultado = (float)a / (float)b;
            Console.WriteLine("");
            Console.WriteLine($"O RESULTADO DA SUA DIVISAO É: \n\n[   {resultado}   ]");
            Console.WriteLine("");
            Console.WriteLine("APERTE ENTER PARA VOLTAR PARA O MENU");

            Console.ReadLine();

        }

        static void MULTIPLICAÇAO()
        {
            Console.WriteLine("");
            Console.WriteLine("MULTIPLICAÇAO DE DOIS NUMEROS: ");
            Console.WriteLine("");
            Console.WriteLine("DIGITE O PRIMEIRO NUMERO: ");
            Console.WriteLine("");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("DIGITE O SEGUNDO NUMERO: ");
            Console.WriteLine("");
            int b = int.Parse(Console.ReadLine());
            int resultado = a * b;
            Console.WriteLine("");
            Console.WriteLine($"O RESULTADO DA SUA MULTIPLICAÇAO É: \n\n[   {resultado}   ]");
            Console.WriteLine("");
            Console.WriteLine("APERTE ENTER PARA VOLTAR PARA O MENU");

            Console.ReadLine();

        }

        static void POTENCIA()
        {
            Console.WriteLine("");
            Console.WriteLine("POTENCIA DE NUMEROS: ");
            Console.WriteLine("");
            Console.WriteLine("DIGITE A BASE: ");
            Console.WriteLine("");
            int basenum = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("DIGITE O EXPOENTE: ");
            Console.WriteLine("");
            int EXPO = int.Parse(Console.ReadLine());
            int resultado = (int)Math.Pow(basenum, EXPO);
            Console.WriteLine("");
            Console.WriteLine($"O RESULTADO DA SUA POTENCIAÇAO É: \n\n[   {resultado}   ]");
            Console.WriteLine("");
            Console.WriteLine("APERTE ENTER PARA VOLTAR PARA O MENU");

            Console.ReadLine();

        }

        static void RAIZ()
        {
            Console.WriteLine("");
            Console.WriteLine("RAIZ NUMERICA: ");
            Console.WriteLine("");
            Console.WriteLine("DIGITE O NUMERO: ");
            Console.WriteLine("");
            int a = int.Parse(Console.ReadLine());
            double resultado = Math.Sqrt(a);
            Console.WriteLine("");
            Console.WriteLine($"O RESULTADO DA SUA RAIZ É: \n\n[   {resultado}   ]");
            Console.WriteLine("");
            Console.WriteLine("APERTE ENTER PARA VOLTAR PARA O MENU");

            Console.ReadLine();

        }
    }  
}
