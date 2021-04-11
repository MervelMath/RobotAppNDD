using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboApp.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("Tamanho de X:");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Tamanho de Y:");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine("Direção inicial:");
            string d = Console.ReadLine();

            Console.WriteLine("Posição de X:");
            int e = int.Parse(Console.ReadLine());

            Console.WriteLine("Posição de Y:");
            int f = int.Parse(Console.ReadLine());

            Console.WriteLine("Entrada:");
            string a = Console.ReadLine();
            */

            Console.WriteLine("Digite o tamanho da área de ação (X Y -> necessário ter espaço entre as informações):");
            string a = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a posição inicial em X para o robô 1, a posição inicial em Y e a direção inicial (X Y Z -> necessidade de espaços):");
            string b = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a linha de comando para movimento do robô 1 (sem espaçamento entre as informações):");
            string c = Console.ReadLine().ToUpper();

            Robot r = new Robot(a, b, c);

            r.DefineDirections();
            r.Output();


            Console.WriteLine("Digite a posição inicial em X (robô 2), a posição inicial em Y e a direção inicial (X Y Z -> necessidade de espaços):");
            string e = Console.ReadLine().ToUpper();

            Console.WriteLine("Digite a linha de comando para movimento do robô 2 (sem espaçamento entre as informações):");
            string f = Console.ReadLine().ToUpper();

            Robot r2 = new Robot(a, e, f);

            r2.DefineDirections();
            r2.Output();

            Console.ReadLine();
        }
    }
}
