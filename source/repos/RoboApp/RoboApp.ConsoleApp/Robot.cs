using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoboApp.ConsoleApp
{
    using System;
    public class Robot
    {

        private char[] userInput;
        private int[] vetorx;
        private int[] vetory;
        private char[] direction;
        private char IniDirection;
        private int local;
        private int posx;
        private int posy;
        private string[] vet;
        private string[] vet2;
        public Robot(string b, string d, string a)
        {
            this.userInput = a.ToCharArray();
            this.vet2 = b.Split(' ');
            this.vetorx = new int[int.Parse(vet2[0])];
            this.vetory = new int[int.Parse(vet2[1])];
            this.vet = d.Split();
            this.posx = int.Parse(vet[0]);
            this.posy = int.Parse(vet[1]);
            this.IniDirection = char.Parse(vet[2]);
        }

        public void DefineDirections()
        {
            this.direction = "NLSO".ToCharArray();
            this.local = "NLSO".IndexOf(IniDirection);
        }
        
        public void Output()
        {
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput[i] == 'E' || userInput[i] == 'e')
                {
                    if (local!=0) {
                        this.local = local - 1;
                    }
                    else if (local == 0)
                    {
                        this.local = local + 3;
                    }
                }

                if (userInput[i] == 'D' || userInput[i] == 'd')
                {
                    if (local != 3)
                    {
                        this.local = local + 1;
                    }
                    else if (local == 3)
                    {
                        this.local = local - 3;
                    }
                }

                if (userInput[i] == 'M' || userInput[i] == 'm')
                {
                    if (local == 0)
                    {
                        posy++;
                    }
                    else if (local == 1)
                    {
                        posx++;
                    }
                    else if (local == 2)
                    {
                        posy--;
                    }
                    else if (local == 3)
                    {
                        posx--;
                    }
                }
            }

           

            if (posx <= vetorx.Length)
            {
                Console.Write(posx + " ");
            }
            else {
                Console.WriteLine(" ");
                Console.WriteLine("Erro, posição final em X fora da área registrada.");
            }

            if (posy <= vetory.Length)
            {
                Console.Write(posy + " ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Erro: a posição final em Y está fora da área registrada.");
            }

            Console.WriteLine(direction[local]);
        }

    }
}
