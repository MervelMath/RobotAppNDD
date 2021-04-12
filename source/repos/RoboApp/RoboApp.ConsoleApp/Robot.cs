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
            ConstructorInternMethod(b, d, a);
        }

        


        public void DefineDirections()
        {
            DefineDirInternMethod();
        }

        private void DefineDirInternMethod()
        {
            this.Direction = "NLSO".ToCharArray();
            this.Local = "NLSO".IndexOf(IniDirection1);
        }

        public void Output()
        {
            InternOutputMethod();
        }


        private void ConstructorInternMethod(string b, string d, string a)
        {
            this.UserInput = a.ToCharArray();
            this.Vet2 = b.Split(' ');
            this.Vetorx = new int[int.Parse(Vet2[0])];
            this.Vetory = new int[int.Parse(Vet2[1])];
            this.Vet = d.Split();
            this.Posx = int.Parse(Vet[0]);
            this.Posy = int.Parse(Vet[1]);
            this.IniDirection1 = char.Parse(Vet[2]);
        }


        private void InternOutputMethod()
        {
            for (int i = 0; i < UserInput.Length; i++)
            {
                if (UserInput[i] == 'E' || UserInput[i] == 'e')
                {
                    if (Local != 0)
                    {
                        this.Local = Local - 1;
                    }
                    else if (Local == 0)
                    {
                        this.Local = Local + 3;
                    }
                }

                if (UserInput[i] == 'D' || UserInput[i] == 'd')
                {
                    if (Local != 3)
                    {
                        this.Local = Local + 1;
                    }
                    else if (Local == 3)
                    {
                        this.Local = Local - 3;
                    }
                }

                if (UserInput[i] == 'M' || UserInput[i] == 'm')
                {
                    if (Local == 0)
                    {
                        Posy++;
                    }
                    else if (Local == 1)
                    {
                        Posx++;
                    }
                    else if (Local == 2)
                    {
                        Posy--;
                    }
                    else if (Local == 3)
                    {
                        Posx--;
                    }
                }
            }



            if (Posx <= Vetorx.Length)
            {
                Console.Write(Posx + " ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Erro, posição final em X fora da área registrada.");
            }

            if (Posy <= Vetory.Length)
            {
                Console.Write(Posy + " ");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("Erro: a posição final em Y está fora da área registrada.");
            }

            Console.WriteLine(Direction[Local]);
        }


        //Declaração de médotos "gets" e "sets"...

        public char[] UserInput { get => userInput; set => userInput = value; }
        public int Posx { get => posx; set => posx = value; }
        public int Posy { get => posy; set => posy = value; }
        public int Local { get => local; set => local = value; }
        public string[] Vet { get => vet; set => vet = value; }
        public string[] Vet2 { get => vet2; set => vet2 = value; }
        public char IniDirection1 { get => IniDirection; set => IniDirection = value; }
        public char[] Direction { get => direction; set => direction = value; }
        public int[] Vetory { get => vetory; set => vetory = value; }
        public int[] Vetorx { get => vetorx; set => vetorx = value; }
    }
}
