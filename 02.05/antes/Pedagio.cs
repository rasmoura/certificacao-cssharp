using System;
using System.Collections.Generic;
using System.Text;

namespace _02._05
{
    class Pedagio
    {
        Queue<string> fila = new Queue<string>();

        public void Enfileirar(string veiculo)
        {
            fila.Enqueue(veiculo);
            Console.WriteLine("Entrou na fila: " + veiculo);
            Imprimir();
        }

        private void Imprimir()
        {
            Console.WriteLine();
            Console.WriteLine("VEÍCULOS NA FILA: ");
            foreach (var v in fila)
            {
                Console.WriteLine(v);
            }
        }

        public void Desenfileirar()
        {
            Console.WriteLine();

            if (fila.Count == 0)
            {
                Console.WriteLine("A fila já está vazia!");
                return;
            }

            var proximoVeiculo = fila.Peek();
            Console.WriteLine("O Próximo da fila é: " + proximoVeiculo);

            var veiculoRemovido = fila.Dequeue();
            Console.WriteLine("Saiu de fila: " + veiculoRemovido);
            Imprimir();

            fila.TryPeek(out proximoVeiculo);
            Console.WriteLine("O próximo da fila é: " + proximoVeiculo);
        }
    }
}
