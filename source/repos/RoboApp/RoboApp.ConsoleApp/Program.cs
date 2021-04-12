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

            string a, b, c;
            UserInputRobot1(out a, out b, out c);

            Robot r = new Robot(a, b, c);

            r.DefineDirections();
            r.Output();

            string e, f;
            UserInputRobot2(out e, out f);

            Robot r2 = new Robot(a, e, f);

            r2.DefineDirections();
            r2.Output();

            Console.ReadLine();
        }

        

        private static void UserInputRobot1(out string a, out string b, out string c)
        {
            Console.WriteLine("Digite o tamanho da área de ação (X Y -> necessário ter espaço entre as informações):");
            a = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a posição inicial em X para o robô 1, a posição inicial em Y e a direção inicial (X Y Z -> necessidade de espaços):");
            b = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a linha de comando para movimento do robô 1 (sem espaçamento entre as informações):");
            c = Console.ReadLine().ToUpper();
        }

        private static void UserInputRobot2(out string e, out string f)
        {
            Console.WriteLine("Digite a posição inicial em X (robô 2), a posição inicial em Y e a direção inicial (X Y Z -> necessidade de espaços):");
            e = Console.ReadLine().ToUpper();
            Console.WriteLine("Digite a linha de comando para movimento do robô 2 (sem espaçamento entre as informações):");
            f = Console.ReadLine().ToUpper();
        }
    }
}
