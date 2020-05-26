using System;

namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem peter = new Personagem();

            Console.WriteLine(peter.nome);
            Console.WriteLine(peter.Atacar());

        }
    }
}
