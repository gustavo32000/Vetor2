using System;

namespace Vetor2
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] nomes = {"Bruno", "Camila", "Raphaela", "Fábio"};

            for(int x = 3; x >= 0; x-- ){
                Console.WriteLine (nomes[x]);

            }
            Console.WriteLine ("--------------------------------------------------------");
            int y = 0;
            while(y <= 3) {
                Console.WriteLine (nomes[y]);
                y++;
            }

        }
    }
}
