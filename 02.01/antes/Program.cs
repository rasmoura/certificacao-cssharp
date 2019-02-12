using System;

namespace _02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string alura = "Alura";
            string caelum = "Caelum";
            string casaDoCodigo = "Casa do Código";

            //Console.WriteLine(alura);
            //Console.WriteLine(caelum);
            //Console.WriteLine(casaDoCodigo);

            //Matriz = Array


            //string[] empresas = new string[3];
            //empresas[0] = alura;
            //empresas[1] = caelum;
            //empresas[2] = casaDoCodigo;

            //string[] empresas = new string[]
            //{
            //    alura,caelum,casaDoCodigo
            //};

            string[] empresas = { alura, caelum, casaDoCodigo };

            //foreach (var item in empresas)
            //{
            //    Console.WriteLine(item);
            //}

            //Imprimir(empresas);

            //caelum = "Caelum Ensino e Inovação";

            //empresas[1] = caelum;

            //Imprimir(empresas);

            //Console.WriteLine("Primeiro elemento: " + empresas[0]);
            //Console.WriteLine("Último elemento: " + empresas[empresas.Length - 1]);

            Console.WriteLine("O índice de 'Casa do Código' é: " + Array.IndexOf(empresas, "Casa do Código"));

            Console.WriteLine("O último de índice de 'Casa do Código' é: " + Array.LastIndexOf(empresas, "Casa do Código"));

            Console.WriteLine("\n");
            Console.WriteLine("Invertendo ordem do Array Empresas:");
            Array.Reverse(empresas);
            Imprimir(empresas);

            Console.WriteLine("\n");
            Console.WriteLine("Invertendo novamente a ordem do Array Empresas:");
            Array.Reverse(empresas);
            Imprimir(empresas);


            Console.WriteLine("\n");
            Console.WriteLine("Redefinindo tamanho do Array Empresas para 2:");
            Array.Resize(ref empresas, 2);
            Imprimir(empresas);

            Console.WriteLine("\n");
            Console.WriteLine("Redefinindo tamanho do Array Empresas para 3:");
            Array.Resize(ref empresas, 3);
            Imprimir(empresas);

            empresas[empresas.Length - 1] = "Casa do Código";

            Console.WriteLine("\n");
            Console.WriteLine("Ordenando Array Empresas alfabeticamente:");
            Array.Sort(empresas);
            Imprimir(empresas);

            Console.WriteLine("\n");
            Console.WriteLine("Copiando Array Empresas para um novo Array:");
            string[] copia = new string[2];
            Array.Copy(empresas, 1, copia, 0, 2);
            Imprimir(copia);

            Console.WriteLine("\n");
            Console.WriteLine("Clonando Array Empresas:");
            string[] clone = empresas.Clone() as string[];
            Imprimir(clone);

            Console.WriteLine("\n");
            Console.WriteLine("Limpando os elementos do Array Clone de Empresas:");
            Array.Clear(clone, 1, clone.Length - 1);
            Imprimir(clone);
        }

        private static void Imprimir(string[] empresas)
        {
            //for (int i = 0; i < empresas.Length; i++)
            //{
            //    Console.WriteLine(empresas[i]);
            //}

            foreach (var empresa in empresas)
            {
                Console.WriteLine(empresa);
            }
        }
    }
}
