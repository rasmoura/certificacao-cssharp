using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppQueue
{
    class Program
    {
        static Queue<string> pedagio = new Queue<string>();

        static void Main(string[] args)
        {
            string veiculo = "van";

            Enfileirar(veiculo);
            Enfileirar("kombi");
            Enfileirar("guincho");
            Enfileirar("pickup");

            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();
            Desenfileirar();

            Console.ReadKey();
        }

        private static void Desenfileirar()
        {
            if (pedagio.Any())
            {
                if (pedagio.Peek() == "guincho")
                {
                    Console.WriteLine("Guincho está fazendo o pagamento.");
                }

                var veiculo = pedagio.Dequeue();

                Console.WriteLine($"Saiu de fila: {veiculo}");

                ImprimirFila();
            }
        }

        private static void Enfileirar(string veiculo)
        {
            Console.WriteLine($"Entrou na fila: {veiculo}");
            pedagio.Enqueue(veiculo);
            ImprimirFila();
        }

        private static void ImprimirFila()
        {
            Console.WriteLine("FILA:");
            foreach (var v in pedagio)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine();
        }
    }
}
